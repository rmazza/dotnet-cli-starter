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
            { new CommandOption("-p", "--p", "test option") }
        };

        public bool HasOptions { get; set; }

        public void Run(string[] args)
        {
            if(!HasOptions)
            {
                PrintCommandHelp("ping", options);
                return;
            }
        }

        public void Print()
        {
            Console.WriteLine("Pong!");
        }
    }
}
