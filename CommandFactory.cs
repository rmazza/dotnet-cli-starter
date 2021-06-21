using CLI.Commands;
using CLI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CLI
{
    public class CommandFactory
    {
        public static List<ICommandBase> commands = new List<ICommandBase>
        {
            new Command<PingCommand>("ping", "prints pong")
        };

        public static ICommandBase GetCommand(string commandArgument)
        {
            return commands.Where(cmd => cmd.Name.ToLower().Equals(commandArgument.ToLower())).SingleOrDefault();
        }
    }
}
