namespace TheEnchantedLibrary.Models;

public class ListBooks : LibraryAction
{
    public override string Message { get; } = "[L]ist all books.";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public ListBooks(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        var books = library.GetBooks();
        _libraryUserInteraction.PrintBooks(books);
    }
}
