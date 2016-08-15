using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using MasterThesis.RestTestsGenerator;
using MasterThesis.RestTestsGenerator.IntermediateCodeGenerator;
using MasterThesis.RestTestsGenerator.UnitTestWriters;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;

namespace MasterThesis.DemoRunner
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give RAML specification file path:");
            var path = Console.ReadLine();

            var generator = new RestTestGenerator(path);

            var result = generator.LoadFile();
            result.Wait(3000);

            if(!result.IsCompleted)
                throw new TaskCanceledException("Timeout passed.");

            var fileName = Path.GetTempFileName();

            generator.GenerateTest(new XUnitTestWriter(),new XmlIntermidiateCodeGenerator(fileName), GetUseCaseBuilder());
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

    }
}
