using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary.Services.Interfaces;

public interface ILibraryUserInteraction
{
    void PrintMessage(string message);
    void PrintBooks(ICollection<Book> books);
    void PrintSingle(Book book);
    char GetUserChoice(string message);
    string ReadInput(string message);
    void ClearScreen();
    void WaitForUser();
    char SortListOrContinue();
}