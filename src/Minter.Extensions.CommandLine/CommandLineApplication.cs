using System;
using System.Linq;
using Minter.Extensions.CommandLine.HelpText;

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

        public void ShowHelp()
        {
            var options = new[]
            {
                new CommandLineOption
                {
                    ShortName = "-v",
                    LongName = "--version",
                    Description = "output the current version"
                },
                new CommandLineOption
                {
                    ShortName = "-h",
                    LongName = "--help",
                    Description = "display help for command"
                },
                new CommandLineOption
                {
                    ShortName = "-t",
                    LongName = "--time",
                    Description = "display current time"
                }
            };

            HelpMessageGenerator.GenerateHelpMessage(this, options, Console.Out);
        }

        public string Name { get; init; } = AppDomain.CurrentDomain.FriendlyName;

        public string Description { get; init; } = string.Empty;

        public Version Version { get; init; } = new ("1.0.0");

        public IHelpMessageGenerator HelpMessageGenerator { get; init; } = new HelpMessageGenerator();
    }
    
    public class CommandLineOption
    {
        public string ShortName { get; init; }
        
        public string LongName { get; init; }
        
        public string Description { get; init; }
    }
}
