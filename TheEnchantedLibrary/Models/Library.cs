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
        return Catalogue;
    }

    public void AddBook(Book book)
    {
        Catalogue.Add(book);
        Console.WriteLine($"Book {book.Id} added! {Environment.NewLine}");

    }
}