using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MasterThesis.RestTestsGenerator;
using MasterThesis.RestTestsGenerator.IntermediateCodeGenerator;
using MasterThesis.RestTestsGenerator.UnitTestWriters;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;
using Microsoft.CSharp;

namespace MasterThesis.DemoRunner
{
    static class Program
    {
        static void Main(string[] args)
        {
            string path;

            if (args.Length == 1)
            {
                path = args[0];
                Console.WriteLine(path);
            }
            else
            {
                Console.WriteLine("Please give RAML specification file path:");
                path = Console.ReadLine();
            }
            var generator = new RestTestGenerator(path);

            var result = generator.LoadFile();
            result.Wait();

            if (!result.IsCompleted)
                throw new TaskCanceledException("Timeout passed.");

            var fileName = Path.GetTempFileName();

            generator.GenerateTest(new XUnitTestWriter(), new XmlIntermidiateCodeGenerator(fileName), GetUseCaseBuilder(), @"D:\kmatj_000\Desktop\tests");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finished generation.");
            Console.WriteLine("Compiling.");
            var dllka = CompileTests(@"D:\kmatj_000\Desktop\tests\test.cs");

            Console.WriteLine("Finished generation. " + dllka);
            var testingProcess =RunTestsInProcess(dllka);

            testingProcess.WaitForExit();

            Console.WriteLine("Finished testing. Code: " + testingProcess.ExitCode);
            
            Console.ReadKey();
        }

        private static Process RunTestsInProcess(string dllka)
        {
           return Process.Start(Path.Combine(Path.GetDirectoryName(dllka), @"tools\xunit.console.exe"), dllka);
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

    }
}
