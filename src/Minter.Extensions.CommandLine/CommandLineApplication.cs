using System;
using System.Linq;

namespace Minter.Extensions.CommandLine
{
    public class CommandLineApplication
    {
        public void Execute(string[] args)
        {
            if (args.Contains("-v"))
            {
                Console.WriteLine(Version);
            }
        }
        
        public string Name { get; init; } = AppDomain.CurrentDomain.FriendlyName;

        public string Description { get; init; } = string.Empty;

        public Version Version { get; init; } = new ("1.0.0");
    }
}
