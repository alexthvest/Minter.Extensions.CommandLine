using System;

namespace Minter.Extensions.CommandLine
{
    public class CommandLineProgramBuilder
    {
        private string? _name;
        private string? _description;
        private Version? _version;
        
        public CommandLineProgramBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        
        public CommandLineProgramBuilder SetDescription(string description)
        {
            _description = description;
            return this;
        }
        
        public CommandLineProgramBuilder SetVersion(Version version)
        {
            _version = version;
            return this;
        }
        
        public CommandLineProgram Build()
        {
            return new(_name, _description, _version);
        }
    }
}
