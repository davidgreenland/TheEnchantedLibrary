using TheEnchantedLibrary.Actions.Interfaces;
using TheEnchantedLibrary.Models;
using TheEnchantedLibrary.Models.Interfaces;

namespace TheEnchantedLibrary.Actions;

public abstract class LibraryAction : ILibraryAction
{
    public abstract string Message { get; }

    public abstract void Execute(ILibrary library);
}