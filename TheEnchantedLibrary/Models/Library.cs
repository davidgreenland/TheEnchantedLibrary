namespace TheEnchantedLibrary.Models;

public class Library
{
    public ICollection<Book> Catalogue { get; private set; } = [];

    public Library()
    {
    }

    public Library(List<Book> books)
    {
        Catalogue = books;
    }
}