using System;

namespace Minter.Extensions.CommandLine
{
    public class CommandLineProgram : CommandLineCommand
    {
        public CommandLineProgram(string name, string? description = null, Version? version = null) : base(name, description)
        {
            Version = version;
        }
        
        public CommandLineProgram() : this(AppDomain.CurrentDomain.FriendlyName) {}

        /// <summary>
        /// 
        /// </summary>
        public Version? Version { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public int Execute(string[] args)
        {
            HelpTextTemplate.Write(this, Console.Out);
            
            return 0;
        }
    }
}
