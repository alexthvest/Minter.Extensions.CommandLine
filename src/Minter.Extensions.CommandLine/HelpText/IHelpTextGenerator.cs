using System.IO;

namespace Minter.Extensions.CommandLine.HelpText
{
    public interface IHelpMessageGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="writer"></param>
        void GenerateHelpMessage(CommandLineApplication command, TextWriter writer);
    }
}
