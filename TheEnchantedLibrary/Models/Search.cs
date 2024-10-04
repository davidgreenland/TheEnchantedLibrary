namespace TheEnchantedLibrary.Models;

public class Search: LibraryAction
{
    public override string Message { get; } = "E[x]it application" + Environment.NewLine;

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public Search(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        _libraryUserInteraction.PrintMessage("|| Goodbye. :-) ||");
    }
}
