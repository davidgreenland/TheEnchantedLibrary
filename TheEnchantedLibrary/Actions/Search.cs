using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class Search : LibraryAction
{
    private readonly ILibraryUserInteraction _libraryUserInteraction;
    public override string Message { get; } = "[S]earch for book.";

    public Search(ILibraryUserInteraction libraryUserInteraction)
    {
        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        if (library.GetBooks().Count == 0)
        {
            _libraryUserInteraction.PrintMessage("The library is currently empty.");
            _libraryUserInteraction.WaitForUser();
            return;
        } 
        var searchTerm = _libraryUserInteraction.ReadInput("Search for title: ");

        var book = library.GetBooks().FirstOrDefault(x => x.Title == searchTerm);

        if (book == null)
        {
            _libraryUserInteraction.PrintMessage("Book not found");
            _libraryUserInteraction.WaitForUser();
        }
        else
        {
            _libraryUserInteraction.PrintSingle(book);
        }
    }
}
