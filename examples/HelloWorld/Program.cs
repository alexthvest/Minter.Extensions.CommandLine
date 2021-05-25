using System;
using Minter.Extensions.CommandLine;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var program = new CommandLineApplication
            {
                Name = "minter",
                Description = "Minter Server CLI tool",
                Version = new Version(0, 0, 1),
            };
            
            program.OnExecute(() =>
            {
                program.ShowHelp();
            });

            program.Execute(args);
        }
    }
}
