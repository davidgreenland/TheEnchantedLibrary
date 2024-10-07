using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class Search : LibraryAction
{
    public override string Message { get; } = "[S]earch for book.";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public Search(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        _libraryUserInteraction.PrintMessage("Remove book.");
        var searchTerm = _libraryUserInteraction.ReadInput("Search for title: ");

        try
        {
            var book = library.GetBooks().First(x => x.Title == searchTerm);
            _libraryUserInteraction.PrintSingle(book);
        }
        catch (InvalidOperationException)
        {
            _libraryUserInteraction.PrintMessage("Book not found");
            _libraryUserInteraction.WaitForUser();
        }
    }
}
