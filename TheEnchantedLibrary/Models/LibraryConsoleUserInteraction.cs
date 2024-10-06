namespace TheEnchantedLibrary.Models;

public class LibraryConsoleUserInteraction : ILibraryUserInteraction
{
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public char GetUserChoice(string prompt)
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

    public void ClearScreen() => Console.Clear();

    public void WaitForUser() => Console.ReadKey();

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
        Console.WriteLine($"{"ID",4} | {"Title",-40} | {"Author",-20} | Spell");
        Console.WriteLine($"{new string('-', 4),4} | {new string('-', 40),-40} | {new string('-', 20),-20} | {new string('-', 30)}");
    }

    private void PrintBook(Book book)
    {
        Console.WriteLine($"{book.Id,4} | {book.Title,-40} | {book.Author,-20} | {book.Spell}");
    }
}