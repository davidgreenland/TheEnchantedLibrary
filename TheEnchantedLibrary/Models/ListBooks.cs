namespace TheEnchantedLibrary.Models;

public class ListBooks : LibraryAction
{
    public override string Message { get; } = "[L]ist all books.";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public ListBooks(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(Library library)
    {

        var books = library.GetBooks();
        var tableHeader = String.Format("{0,4} | {1,-40} | {2,-20} | {3}", "ID", "Title", "Author", "Spell");

        _libraryUserInteraction.PrintMessage("Here is a list of the books in the library");
        _libraryUserInteraction.PrintMessage(tableHeader);
        _libraryUserInteraction.PrintMessage(String.Format("{0,4} | {1,-40} | {2,-20} | {3}",
            new string('-', 4), new string('-', 40), new string('-', 20), new string('-', 30)));

        foreach (var book in books)
        {
            PrintBook(book);
        }

        _libraryUserInteraction.PrintMessage(Environment.NewLine);
    }

    private void PrintBook(Book book)
    {
        _libraryUserInteraction.PrintMessage(String.Format("{0,4} | {1,-40} | {2,-20} | {3}", book.Id, book.Title, book.Author, book.Spell));
    }
}
