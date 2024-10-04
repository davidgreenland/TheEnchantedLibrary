namespace TheEnchantedLibrary.Models;

public class RemoveBook : LibraryAction
{

    public override string Message { get; } = "[R]emove a book";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public RemoveBook(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(Library library)
    {
        _libraryUserInteraction.PrintMessage("Remove book.");
        var title = _libraryUserInteraction.ReadInput("Enter the title of the book to remove: ");
        try
        {
            var book = library.GetBooks().First(x => x.Title == title);
            library.RemoveBook(book);
            _libraryUserInteraction.PrintMessage("");
            _libraryUserInteraction.PrintMessage($"| {title} removed. |");
            _libraryUserInteraction.PrintMessage("");
        }
        catch (InvalidOperationException)
        {
            _libraryUserInteraction.PrintMessage("Book not found");
        }
    }
}
