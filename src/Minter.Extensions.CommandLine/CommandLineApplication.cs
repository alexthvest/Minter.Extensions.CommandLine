using System;
using System.Collections.Generic;
using System.Linq;
using Minter.Extensions.CommandLine.HelpText;

namespace Minter.Extensions.CommandLine
{
    public class CommandLineApplication
    {
        private readonly List<CommandLineApplication> _commands = new();
        private readonly List<CommandLineOption> _options = new();

        private Action? _action;

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; init; } = AppDomain.CurrentDomain.FriendlyName;

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; init; } = string.Empty;
        
        /// <summary>
        /// 
        /// </summary>
        public Version Version { get; init; } = new ("1.0.0");

        /// <summary>
        /// 
        /// </summary>
        public IHelpTextTemplate HelpTextTemplate { get; init; } = new HelpTextTemplate();

        /// <summary>
        /// 
        /// </summary>
        public IReadOnlyCollection<CommandLineApplication> Commands => _commands;
        
        /// <summary>
        /// 
        /// </summary>
        public IReadOnlyCollection<CommandLineOption> Options => _options;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="builder"></param>
        public void Command(string name, string description, Action<CommandLineApplication> builder)
        {
            var command = new CommandLineApplication()
            {
                Name = name,
                Description = description,
                Version = Version,
                HelpTextTemplate = HelpTextTemplate
            };

            builder.Invoke(command);

            _commands.Add(command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="template"></param>
        /// <param name="description"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Option(string template, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        public void OnExecute(Action action)
        {
            _action = action;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowHelp()
        {
            HelpTextTemplate.Write(this, Console.Out);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                _action?.Invoke();
                return;
            }
            
            if (args.Contains("-v"))
            {
                Console.WriteLine(Version);
                return;
            }
        }
    }
}
