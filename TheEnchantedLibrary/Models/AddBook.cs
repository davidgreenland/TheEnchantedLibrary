namespace TheEnchantedLibrary.Models;

public class AddBook : LibraryAction
{
    public override string Message { get; } = "[A]dd a book";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public AddBook(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(Library library)
    {
        _libraryUserInteraction.PrintMessage("Add a book to the library.");
        var name = _libraryUserInteraction.ReadInput("Enter the name of the book: ");
        var author = _libraryUserInteraction.ReadInput("Enter the author: ");
        var spell = _libraryUserInteraction.ReadInput("Add a magic spell: ");
        library.AddBook(name, author, spell);
    }

    //private Book PromptForDetails()
    //{
    //    Console.WriteLine("Add a book to the library.");
    //    var name = ReadInput("Enter the name of the book: ");
    //    var author = ReadInput("Enter the author: ");
    //    var spell = ReadInput("Add a magic spell: ");

    //    return new Book(name, author, spell);
    //}
}