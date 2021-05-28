using System.Collections.Generic;
using Minter.Extensions.CommandLine.HelpText;

namespace Minter.Extensions.CommandLine
{
    public class CommandLineCommand
    {
        private readonly List<CommandLineOption> _options = new();
        private readonly List<CommandLineCommand> _commands = new();
        
        public CommandLineCommand(string name, string? description = null)
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Command name
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Command description
        /// </summary>
        public string? Description { get; init; }

        /// <summary>
        /// Template of usage text
        /// </summary>
        public IHelpTextTemplate HelpTextTemplate { get; init; } = new HelpTextTemplate();

        /// <summary>
        /// List of command options
        /// </summary>
        public IReadOnlyCollection<CommandLineOption> Options => _options;
        
        /// <summary>
        /// List of command subcommands
        /// </summary>
        public IReadOnlyCollection<CommandLineCommand> Commands => _commands;
    }
}
