namespace TheEnchantedLibrary.Models;

public class Library : ILibrary
{
    private ICollection<Book> _books = [];

    public Library()
    {
    }

    public Library(List<Book> books)
    {
        _books = books;
    }

    public ICollection<Book> GetBooks()
    {
        return _books;
    }

    public void AddBook(Book book)
    {
        Catalogue.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Catalogue.Remove(book);
    }
}