using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public class HelpTextHeaderTemplate : IHelpTextTemplate
    {
        public void Write(CommandLineCommand command, TextWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine($"Usage: {command.Name} [options] [command]");
            
            if (command.Description?.Length > 0)
            {
                writer.WriteLine();
                writer.WriteLine(command.Description);
            }
        }
    }
}
