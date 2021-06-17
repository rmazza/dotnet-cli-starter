using System.Collections.Generic;

namespace CLI.Interfaces
{
    public interface ICommand
    {
        bool HasOptions { get; set; }

        void Run(string[] args);
        void Print();
    }
}
