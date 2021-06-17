namespace CLI.Interfaces
{
    public interface ICommand
    {
        void Run(string[] args);
        void Print();
    }
}
