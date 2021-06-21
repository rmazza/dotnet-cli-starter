using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using CLI.Interfaces;

namespace CLI
{
    public class CommandRunner : ICommandRunner
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _config;

        public CommandRunner(ILogger<CommandRunner> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void Start(string[]  args)
        {
            // Help
            if (args.Length == 0 || CommandUtility.IsHelp(args[0]))
            {
                CommandUtility.PrintCliHelp(CommandFactory.commands, _config);
            }

            // Version
            if (IsVersion(args[0]))
            {
                Console.WriteLine(_config.GetValue<string>("version"));
            }


            ICommandBase cmd = CommandFactory.GetCommand(args[0]);

            if (cmd.IsNull()) return;

            cmd.Run(args);

        }

        public bool IsVersion(string firstArg)
        {
            return firstArg.ToLower().Equals("-v") || firstArg.ToLower().Equals("--version");
        }


        public void HandleException(Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }
}
