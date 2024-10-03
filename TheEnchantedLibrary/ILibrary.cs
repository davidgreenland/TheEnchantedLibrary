using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public interface ILibrary
{
    ICollection<Book> GetBooks();
    void AddBook(Book book);
    void RemoveBook(Book book);
}