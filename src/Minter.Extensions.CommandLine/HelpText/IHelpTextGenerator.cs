using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public interface IHelpMessageGenerator
    {
        void GenerateHelpMessage(CommandLineApplication application, CommandLineOption[] options, TextWriter writer);
    }
}
