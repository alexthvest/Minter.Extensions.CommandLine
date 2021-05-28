using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public class HelpTextTemplate : IHelpTextTemplate
    {
        private readonly IHelpTextTemplate? _header;
        private readonly IHelpTextTemplate? _options;
        private readonly IHelpTextTemplate? _commands;
        
        public HelpTextTemplate(string optionsSeperator = ", ") 
            : this(
                new HelpTextHeaderTemplate(), 
                new HelpTextOptionsTemplate(optionsSeperator), 
                new HelpTextCommandTemplate())
        {
        }

        public HelpTextTemplate(IHelpTextTemplate header, IHelpTextTemplate options, IHelpTextTemplate commands)
        {
            _header = header;
            _options = options;
            _commands = commands;
        }
        
        public void Write(CommandLineCommand command, TextWriter writer)
        {
            _header?.Write(command, writer);
            _options?.Write(command, writer);
            _commands?.Write(command, writer);
        }
    }
}
