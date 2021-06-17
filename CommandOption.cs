using CLI.Interfaces;

namespace CLI
{
    public class CommandOption : ICommandOption
    {
        private readonly string _shortOption;
        private readonly string _longOption;
        private readonly string _description;

        public string ShortOption => _shortOption;
        public string LongOption => _longOption;
        public string Description => _description;

        public CommandOption(string shortOption, string longOption, string description)
        {
            _shortOption = shortOption;
            _longOption = longOption;
            _description = description;
        }
    }
}
