using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public interface ILibrary
{
    ICollection<Book> GetBooks();
}