using System;
using System.Collections.Generic;

namespace Minter.Extensions.CommandLine
{
    public class CommandLineProgram : CommandLineCommand
    {
        public CommandLineProgram(string? name, string? description = null, Version? version = null) 
            : base(name ?? AppDomain.CurrentDomain.FriendlyName, description)
        {
            Version = version;
        }
        
        public CommandLineProgram() : this(null) {}

        /// <summary>
        /// 
        /// </summary>
        public Version? Version { get; init; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public int Execute(IReadOnlyCollection<string> args)
        {
            return 0;
        }
    }
}
