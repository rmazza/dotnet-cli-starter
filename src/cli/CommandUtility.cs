using CLI.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CLI
{
    public static class CommandUtility
    {
        public static void PrintCliHelp(List<ICommandBase> commands, IConfiguration config)
        {
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;

            var sb = new StringBuilder();

            sb.AppendLine($"{assemblyName} ({config.GetValue<string>("version")})");
            sb.AppendLine($"Usage: {assemblyName} [command] [command-options]");
            sb.AppendLine();

            if (commands.Count > 0)
            {
                sb.AppendLine("Commands:");
                foreach(ICommandBase command in commands)
                {
                    sb.AppendLine($"  {command.Name}              {command.Description}");
                }
            }

            sb.AppendLine();
            sb.AppendLine($"Run '{assemblyName} [command] --help' for more information on a command.");
            Console.WriteLine(sb.ToString());
        }
    }
}
