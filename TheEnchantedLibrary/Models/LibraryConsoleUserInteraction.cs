namespace TheEnchantedLibrary.Models;

public class LibraryConsoleUserInteraction : ILibraryUserInteraction
{
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintBooks(ICollection<Book> books)
    {
        var tableHeader = String.Format("{0,4} | {1,-40} | {2,-20} | {3}", "ID", "Title", "Author", "Spell");

        Console.WriteLine($"Here is a list of the books in the library");
        Console.WriteLine(tableHeader);
        Console.WriteLine(String.Format("{0,4} | {1,-40} | {2,-20} | {3}", 
            new string('-', 4), new string('-', 40), new string('-', 20), new string('-', 30)));

        foreach (var book in books)
        {
            PrintBook(book);
        }
        Console.WriteLine();
    }

    private void PrintBook(Book book) 
    {
        Console.WriteLine(String.Format("{0,4} | {1,-40} | {2,-20} | {3}", book.Id, book.Title, book.Author, book.Spell));
    }
}