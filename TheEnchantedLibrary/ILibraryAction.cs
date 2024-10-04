using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public interface ILibraryAction
{
    void Execute(ILibrary library);
}
