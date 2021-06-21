using CLI.Interfaces;
using System.Linq;

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
}
