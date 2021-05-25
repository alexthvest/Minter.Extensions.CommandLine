using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public class HelpTextOptionsTemplate : IHelpTextTemplate
    {
        private readonly string _seperator;

        public HelpTextOptionsTemplate(string seperator = ", ")
        {
            _seperator = seperator;
        }
        
        public void Write(CommandLineApplication command, TextWriter writer)
        {
            if (command.Options.Count > 0)
            {
                writer.WriteLine();
                writer.WriteLine("Options: ");

                foreach (var option in command.Options)
                {
                    writer.WriteLine($"  {option.ShortName}{_seperator}{option.LongName}\t\t{option.Description}");
                }
            }
        }
    }
}
