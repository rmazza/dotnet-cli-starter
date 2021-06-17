using CLI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLI.Commands
{
    internal class CommandBase
    {
        internal void PrintCommandHelp(string command, IList<ICommandOption> options)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Usage: {command} [options]");
            sb.AppendLine();

            if (options.Count > 0)
            {
                sb.AppendLine("Options:");

                foreach (ICommandOption option in options)
                {
                    sb.AppendLine($"  {option.ShortOption}, {option.LongOption}     {option.Description}");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
