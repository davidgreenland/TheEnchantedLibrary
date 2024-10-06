namespace TheEnchantedLibrary.Models;

public class Library : ILibrary
{
    private readonly ICollection<Book> _books = [];
    private int _bookIdCounter;

    public Library()
    {
    }

    public ICollection<Book> GetBooks()
    {
        return _books;
    }

    public Book AddBook(string title, string author, string spell)
    {
        var book = new Book(GetNewBookId(), title, author, spell);
        _books.Add(book);
        return book;
    }

    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }

    private int GetNewBookId()
    {
        return ++_bookIdCounter;
    }
}