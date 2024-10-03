namespace TheEnchantedLibrary.Models;

public class Library : ILibrary
{
    private ICollection<Book> Catalogue = [];

    public Library()
    {
    }

    public Library(List<Book> books)
    {
        Catalogue = books;
    }

    public ICollection<Book> List()
    {
        Console.WriteLine("Printing books");
        return Catalogue;
    }
}
