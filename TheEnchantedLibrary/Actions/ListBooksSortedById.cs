using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class ListBooksSortedById : LibraryAction
{
    public override string Message { get; } = "[L]ist all books.";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public ListBooksSortedById(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        var books = library.GetBooks().OrderBy(book => book.Id).ToList();

        _libraryUserInteraction.ClearScreen();
        _libraryUserInteraction.PrintBooks(books);
    }
}