using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public class HelpTextCommandTemplate : IHelpTextTemplate
    {
        public void Write(CommandLineCommand command, TextWriter writer)
        {
            if (command.Commands.Count > 0)
            {
                writer.WriteLine();
                writer.WriteLine("Commands: ");

                foreach (var cmd in command.Commands)
                {
                    writer.WriteLine($"  {cmd.Name}\t\t{cmd.Description}");
                }
            }
        }
    }
}
