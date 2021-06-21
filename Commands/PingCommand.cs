using CLI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLI.Commands
{
    class PingCommand : CommandBase, ICommand
    {
        private List<ICommandOption> options = new List<ICommandOption>
        {
            { new CommandOption("-p", "--p", "test command to ensure proper hook up.", pCommand) }
        };

        public void Run(string[] args)
        {
            //TODO: create method for checking help flag not just for first option
            if (!HasOptions || args.IsHelp())
            {
                PrintCommandHelp("ping", options);
                return;
            }
        }

        private static Func<bool> pCommand = () => true;


        public void Print()
        {
            Console.WriteLine("Pong!");
        }
    }
}
