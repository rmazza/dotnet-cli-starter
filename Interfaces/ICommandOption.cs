namespace CLI.Interfaces
{
    public interface ICommandOption
    {
        string ShortOption { get; }
        string LongOption { get; }
        string Description { get; }
    }
}
