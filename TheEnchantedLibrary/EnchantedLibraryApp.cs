using TheEnchantedLibrary.Helpers;
using TheEnchantedLibrary.Models;

namespace TheEnchantedLibrary;

public class EnchantedLibraryApp
{
    private readonly ILibrary _library;
    private readonly LibraryActions _libraryActions;
    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public EnchantedLibraryApp(LibraryActions actions, ILibraryUserInteraction libraryUserInteraction, ILibrary library)
    {
        _libraryActions = actions;
        _libraryUserInteraction = libraryUserInteraction;
        _library = library;
    }

    public void StartApp()
    {
        char userChoice;
        _libraryUserInteraction.PrintMessage("Welcome to the Enchanted Library");
        _libraryUserInteraction.PrintMessage("Press any key to begin");
        _libraryUserInteraction.WaitForUser();

        do
        {
            _libraryUserInteraction.ClearScreen();
            userChoice = GetUserChoice();

            if (_libraryActions.Actions.ContainsKey(userChoice)) 
            {
                _libraryUserInteraction.ClearScreen();
                _libraryActions.UseAction(userChoice, _library);
            }
        } 
        while (userChoice != ActionKey.EXIT_APP);
    }

    private char GetUserChoice()
    {
        ShowOptions();
        var userChoice = _libraryUserInteraction.GetUserChoice("Choose an option: ");
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