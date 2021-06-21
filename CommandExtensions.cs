using CLI.Interfaces;
using System.Linq;
using System.CommandLine.Parser;

namespace CLI
{
    public static class CommandExtensions
    {
        public static bool IsNull(this ICommandBase cmd)
        {
            return cmd == null;
        }

        public static bool IsHelp(this string[] str)
        {
            return str.Any(x => x.ToLower().Equals("-h") || x.ToLower().Equals("--help"));
        }
    }

    public static class ParserExtensions
    {
        public static ParseResult ParseFrom(
            this Parser parser,
            string context,
            string[] args) =>
            parser.Parse(context.Split(' ').Concat(args).ToArray());
    }
}
