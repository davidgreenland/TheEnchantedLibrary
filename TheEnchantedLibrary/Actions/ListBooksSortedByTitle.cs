using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class ListBooksSortedByTitle : LibraryAction
{
    public override string Message { get; } = "[L]ist all books.";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public ListBooksSortedByTitle(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        var books = library.GetBooks().OrderBy(book => book.Title).ToList();

        _libraryUserInteraction.ClearScreen();
        _libraryUserInteraction.PrintBooks(books);
    }
}
