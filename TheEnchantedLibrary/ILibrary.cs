using System.Reflection;
using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public interface ILibrary
{
    ICollection<Book> GetBooks();
    void AddBook(string title, string author, string spell);
    void RemoveBook(Book book);
}