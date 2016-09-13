using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;
using MasterThesis.RestTestsGenerator;
using MasterThesis.RestTestsGenerator.IntermediateCodeGenerator;
using MasterThesis.RestTestsGenerator.UnitTestWriters;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;
using Microsoft.CSharp;
using MasterThesis.Common.Helpers;

namespace MasterThesis.DemoRunner
{
    static class Program
    {
        private const string TempDir = @"D:\kmatj_000\Desktop\tests\";

        static void Main(string[] args)
        {
            string path;

            if (args.Length == 1)
            {
                path = args[0];
                Console.WriteLine("Loaded file: "+path);
            }
            else
            {
                Console.WriteLine("Please give RAML specification file path:");
                path = Console.ReadLine();
            }
            var generator = new RestTestGenerator(path);

            var result = generator.LoadFile();
            result.Wait();

            var fileName = Path.GetTempFileName();

            generator.GenerateTest(new XUnitTestWriter(), new XmlIntermidiateCodeGenerator(fileName), GetUseCaseBuilder(), TempDir);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finished generation.");
            Console.WriteLine("Compiling.");
            var dllka = CompileTests(TempDir+ "test.cs");

            Console.WriteLine("Finished generation. " + dllka);


            Console.WriteLine("Copy tools...");
            UnzipTools(@".\UnitTestTemplates\tools.zip", TempDir);

            Console.WriteLine("Executing tests...");
            var testingProcess = GetTestingProcess(dllka);
            testingProcess.Start();
            testingProcess.WaitForExit();

            Console.WriteLine("Finished testing. Code: " + testingProcess.ExitCode);
            Console.WriteLine(testingProcess.StandardOutput.ReadToEnd());
        }

        private static Process GetTestingProcess(string dllka)
        {
            var p = new Process();
            p.StartInfo.FileName = Path.Combine(Path.GetDirectoryName(dllka), @"tools\xunit.console.exe");
            p.StartInfo.Arguments = dllka;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;

            return p;
        }


        private static CompositeUseCaseBuilder GetUseCaseBuilder()
        {
            var useCaseBuilder = new CompositeUseCaseBuilder();
            useCaseBuilder.AddUseCaseBuilder(new CheckMethodCodeUseCaseBuilder());
            useCaseBuilder.AddUseCaseBuilder(new RequestHeaderCheckUseCaseBuilder());
            useCaseBuilder.AddUseCaseBuilder(new ContentSchemaCheckUseCaseBuilder());
            useCaseBuilder.AddUseCaseBuilder(new ResponseHeaderPatternCheckUseCaseBuilder());
            return useCaseBuilder;
        }


        private static string CompileTests(string testUrl)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            // Reference to System.Drawing library
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Runtime.dll");
            parameters.ReferencedAssemblies.Add("System.Net.Http.dll");
            parameters.ReferencedAssemblies.Add("xunit.core.dll");
            parameters.ReferencedAssemblies.Add("xunit.assert.dll");
            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = false;
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = false;
            parameters.OutputAssembly = @"D:\kmatj_000\Desktop\tests\OutputAssembly.dll";

            CompilerResults results = provider.CompileAssemblyFromSource(parameters, File.ReadAllText(testUrl));

            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine($"Error ({error.ErrorNumber}): {error.ErrorText}");
                }

                throw new InvalidOperationException(sb.ToString());
            }

            return parameters.OutputAssembly;
        }

        private static void UnzipTools(string zipFile, string destinationDir)
        {
            var archive = ZipFile.Open(zipFile, ZipArchiveMode.Read);
            archive.ExtractToDirectory(destinationDir,true);
        }
    }
}
