using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public interface IHelpTextTemplate
    {
        void Write(CommandLineCommand command, TextWriter writer);
    }
}
