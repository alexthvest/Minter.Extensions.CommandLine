using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public class HelpMessageGenerator : IHelpMessageGenerator
    {
        public void GenerateHelpMessage(CommandLineApplication command, TextWriter writer)
        {
            // TODO
            writer.WriteLine($"Usage: {command.Name} [options] [command]");
            writer.WriteLine();

            if (command.Description.Length > 0)
            {
                writer.WriteLine(command.Description);
                writer.WriteLine();
            }

            if (command.Options.Count > 0)
            {
                writer.WriteLine("Options: ");

                foreach (var option in command.Options)
                {
                    writer.WriteLine($"  {option.ShortName}, {option.LongName}\t\t{option.Description}");
                }
            }
            
            if (command.Commands.Count > 0)
            {
                writer.WriteLine("Commands: ");

                foreach (var cmd in command.Commands)
                {
                    writer.WriteLine($"  {cmd.Name}\t\t{cmd.Description}");
                }
            }
        }
    }
}
