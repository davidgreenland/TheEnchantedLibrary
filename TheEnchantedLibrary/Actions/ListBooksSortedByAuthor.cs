using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class ListBooksSortedByAuthor : LibraryAction
{
    private readonly ILibraryUserInteraction _libraryUserInteraction;
    public override string Message { get; } = "[L]ist all books.";

    public ListBooksSortedByAuthor(ILibraryUserInteraction libraryUserInteraction)
    {
        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        var books = library.GetBooks().OrderBy(book => book.Author).ToList();

        _libraryUserInteraction.ClearScreen();
        _libraryUserInteraction.PrintBooks(books);
    }
}