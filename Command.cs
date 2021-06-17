using CLI.Interfaces;

namespace CLI
{
    public class Command<T>: ICommandBase where T : ICommand, new()
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Command(string name, string desc)
        {
            Name = name;
            Description = desc;
        }

        public void Run(string[] args)
        {
            new T().Run(args);
        }
    }
}
