namespace TheEnchantedLibrary.Models;

public class Library : ILibrary
{
    private ICollection<Book> _books = [];
    private int _bookIdCounter;

    public Library()
    {
    }

    public ICollection<Book> GetBooks()
    {
        return _books;
    }

    public void AddBook(string title, string author, string spell)
    {
        _books.Add(new Book(GetNewBookId(), title, author, spell));
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