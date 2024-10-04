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
        char userChoice;
        _libraryUserInteraction.PrintMessage("Welcome to the Enchanted Library");
        do
        {
            userChoice = GetUserChoice();
            _libraryActions.UseAction(userChoice, _library);
        } 
        while (userChoice != 'X');
    }

    private char GetUserChoice()
    {
        char userChoice;
        do
        {
            ShowOptions();
            userChoice = _libraryUserInteraction.GetChar("Choose an option:");
        }
        while (!_libraryActions.Actions.ContainsKey(userChoice));

        return userChoice;
    }

    private void ShowOptions()
    {
        foreach (var item in _libraryActions.Actions)
        {
            _libraryUserInteraction.PrintMessage(item.Value.Message);
        }
    }
}