using CLI.Interfaces;
using System;

namespace CLI.Commands
{
    class PingCommand : ICommand
    {
        public void Run(string[] args)
        {
            Print();
        }

        public void Print()
        {
            Console.WriteLine("Pong!");
        }
    }
}
