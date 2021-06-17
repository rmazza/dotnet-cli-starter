using CLI.Interfaces;

namespace CLI
{
    public class Command<T> : ICommandBase where T : ICommand, new()
    {
        private string _name;
        private string _description;

        public string Name => _name;
        public string Description => _description;

        public Command(string name, string desc)
        {
            _name = name;
            _description = desc;
        }

        public void Run(string[] args)
        {
            T instance = new T
            {
                HasOptions = args.Length > 1
            };

            instance.Run(args);
        }
    }
}
