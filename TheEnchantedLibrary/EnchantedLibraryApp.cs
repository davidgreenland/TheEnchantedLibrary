using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public class EnchantedLibraryApp
{
    private readonly Library _library;
    private readonly LibraryActions _libraryActions;
    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public EnchantedLibraryApp(LibraryActions actions, ILibraryUserInteraction libraryUserInteraction, Library library)
    {
        _libraryActions = actions;
        _libraryUserInteraction = libraryUserInteraction;
        _library = library;
    }

    public void StartApp()
    {
        _libraryUserInteraction.PrintMessage("Welcome to the Enchanted Library");
        ShowOptions();
        var userChoice = GetUserChoice();
        _libraryActions.UseAction(userChoice, _library);
        _libraryUserInteraction.PrintBooks(_library.GetBooks());
    }

    private void ShowOptions()
    {
        foreach (var item in _libraryActions.Actions)
        {
            _libraryUserInteraction.PrintMessage(item.Value.Message);
        }
    }

    private char GetUserChoice()
    {
        char userChoice;
        do
        {
            userChoice = _libraryUserInteraction.GetChar("Choose an option:");
        }
        while (!_libraryActions.Actions.ContainsKey(userChoice));

        return userChoice;
    }
}