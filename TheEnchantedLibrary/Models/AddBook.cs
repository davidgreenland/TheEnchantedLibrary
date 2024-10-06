namespace TheEnchantedLibrary.Models;

public class AddBook : LibraryAction
{
    public override string Message { get; } = "[A]dd a book";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public AddBook(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        _libraryUserInteraction.PrintMessage("Add a book to the library." + Environment.NewLine);
        var name = _libraryUserInteraction.ReadInput("Enter the name of the book: ");
        var author = _libraryUserInteraction.ReadInput("Enter the author: ");
        var spell = _libraryUserInteraction.ReadInput("Add a magic spell: ");
        var newBook = library.AddBook(name, author, spell);
        _libraryUserInteraction.PrintMessage(Environment.NewLine + $"{newBook} added");
        _libraryUserInteraction.WaitForUser();
    }
}