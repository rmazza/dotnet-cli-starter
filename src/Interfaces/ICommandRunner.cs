using System;

namespace CLI.Interfaces
{
    public interface ICommandRunner
    {
        void Start(string[] args);
        void HandleException(Exception ex);
    }
}
