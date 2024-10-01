namespace TheEnchantedLibrary.Models;

public class Library
{
    public List<Book> Catalogue { get; private set; }

    public Library()
    {
        Catalogue = [];
    }

    public Library(List<Book> books)
    {
        Catalogue = books;
    }
}