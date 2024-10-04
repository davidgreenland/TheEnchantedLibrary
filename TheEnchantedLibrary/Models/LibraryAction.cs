using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public abstract class LibraryAction : ILibraryAction
{
    public abstract string Message { get; }

    public abstract void Execute(Library library);
}