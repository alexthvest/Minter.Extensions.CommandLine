using System.IO;
using System.Text;

namespace Minter.Extensions.CommandLine.HelpText
{
    public class HelpMessageGenerator : IHelpMessageGenerator
    {
        public void GenerateHelpMessage(CommandLineApplication application, CommandLineOption[] options, TextWriter writer)
        {
            // TODO
            writer.WriteLine($"Usage: {application.Name} [options] [command]");
            writer.WriteLine();
            
            writer.WriteLine(application.Description);
            writer.WriteLine();

            if (options.Length > 0)
            {
                writer.WriteLine("Options: ");

                foreach (var option in options)
                {
                    writer.WriteLine($"  {option.ShortName}, {option.LongName}\t\t{option.Description}");
                }
            }
        }
    }
}
