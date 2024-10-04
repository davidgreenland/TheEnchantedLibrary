using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public interface ILibraryUserInteraction
{
    void PrintMessage(string message);
    void PrintBooks(ICollection<Book> books);
    char GetChar(string message);
    string ReadInput(string message);
}