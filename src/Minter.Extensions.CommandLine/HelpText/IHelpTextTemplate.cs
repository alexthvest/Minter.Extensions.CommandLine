using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public interface IHelpTextTemplate
    {
        void Write(CommandLineApplication command, TextWriter writer);
    }
}
