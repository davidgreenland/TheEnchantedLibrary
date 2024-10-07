using TheEnchantedLibrary.Models.Interfaces;

namespace TheEnchantedLibrary.Actions.Interfaces;

public interface ILibraryAction
{
    void Execute(ILibrary library);
}
