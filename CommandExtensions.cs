using CLI.Interfaces;

namespace CLI
{
    public static class CommandExtensions
    {
        public static bool IsNull(this ICommandBase cmd)
        {
            return cmd == null;
        }
    }
}
