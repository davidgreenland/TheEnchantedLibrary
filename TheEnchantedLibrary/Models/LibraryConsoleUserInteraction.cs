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

    public void PrintBooks(ICollection<Book> books)
    {
        Console.WriteLine($"Here is a list of the books in the library");
        PrintTableHeader();

        foreach (var book in books)
        {
            PrintBook(book);
        }
        Console.WriteLine();
    }

    private void PrintTableHeader()
    {
        Console.WriteLine(String.Format("{0,4} | {1,-40} | {2,-20} | {3}", "ID", "Title", "Author", "Spell"));
        Console.WriteLine(String.Format("{0,4} | {1,-40} | {2,-20} | {3}",
            new string('-', 4), new string('-', 40), new string('-', 20), new string('-', 30)));
    }

    private void PrintBook(Book book)
    {
        Console.WriteLine(String.Format("{0,4} | {1,-40} | {2,-20} | {3}", book.Id, book.Title, book.Author, book.Spell));
    }
}