using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class RemoveBook : LibraryAction
{
    public override string Message { get; } = "[R]emove a book";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public RemoveBook(ILibraryUserInteraction libraryUserInteraction)
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

        _libraryUserInteraction.PrintMessage("Remove book.");
        var title = _libraryUserInteraction.ReadInput("Enter the title of the book to remove: ");

        var book = library.GetBooks().FirstOrDefault(x => x.Title == title);

        if (book == null)
        {
            _libraryUserInteraction.PrintMessage("Book not found");
        }
        else
        {
            library.RemoveBook(book);
            _libraryUserInteraction.PrintMessage($"{title} removed.");
        }
    }
}