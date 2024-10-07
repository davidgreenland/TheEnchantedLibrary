namespace TheEnchantedLibrary.Models.Interfaces;

public interface ILibrary
{
    ICollection<Book> GetBooks();
    Book AddBook(string title, string author, string spell);
    void RemoveBook(Book book);
}