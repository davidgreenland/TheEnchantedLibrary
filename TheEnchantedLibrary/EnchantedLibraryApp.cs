namespace TheEnchantedLibrary;

public class EnchantedLibraryApp
{
    private readonly ILibrary _library;
    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public EnchantedLibraryApp(ILibrary library, ILibraryUserInteraction libraryUserInteraction)
    {
        _library = library;
        _libraryUserInteraction = libraryUserInteraction;
    }

    public void StartApp()
    {
        _libraryUserInteraction.PrintMessage("Welcome to the Enchanted Library");
        _libraryUserInteraction.PrintBooks(_library.GetBooks());
    }
}