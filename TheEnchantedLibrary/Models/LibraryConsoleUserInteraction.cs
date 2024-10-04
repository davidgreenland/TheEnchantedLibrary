namespace TheEnchantedLibrary.Models;

public class LibraryConsoleUserInteraction : ILibraryUserInteraction
{
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public char GetChar(string prompt)
    {
        Console.Write(prompt);
        var input = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(Environment.NewLine);
        return input;
    }

    public string ReadInput(string prompt)
    {
        string? input;

        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(input));

        return input;
    }

    //private void ShowOptions()
    //{
    //    Console.WriteLine("[A]dd a new book.");
    //    Console.WriteLine("[L]ist all books.");
    //    Console.WriteLine("[R]emove a book.");
    //    Console.WriteLine("[S]earch for a book");
    //    Console.WriteLine("[E]xit");
    //    Console.Write("Choose an option:");
    //}

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