namespace TheEnchantedLibrary.Models;

public class Library : ILibrary
{
    private ICollection<Book> _books = [];
    private int _bookIdCounter = 0;

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

    public void AddBook(string title, string author, string spell)
    {
        _bookIdCounter++;
        _books.Add(new Book(_bookIdCounter, title, author, spell));
    }

    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }
}