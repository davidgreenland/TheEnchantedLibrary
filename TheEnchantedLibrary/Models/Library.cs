namespace TheEnchantedLibrary.Models;

public class Library
{
    private ICollection<Book> Catalogue = [];

    public Library()
    {
    }

    public Library(List<Book> books)
    {
        Catalogue = books;
    }
}