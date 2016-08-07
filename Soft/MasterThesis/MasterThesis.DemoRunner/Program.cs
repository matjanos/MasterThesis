using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MasterThesis.RestTestsGenerator;

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
        }

    }
}
