using TheEnchantedLibrary.Actions;
using TheEnchantedLibrary.Helpers;
using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Services;

public class EnchantedLibraryApp
{
    private readonly ILibrary _library;
    private readonly Dictionary<char, LibraryAction> _libraryActions;
    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public EnchantedLibraryApp(Dictionary<char, LibraryAction> libraryActions, ILibraryUserInteraction libraryUserInteraction, ILibrary library)
    {
        _libraryActions = libraryActions;
        _libraryUserInteraction = libraryUserInteraction;
        _library = library;
    }

    public void StartApp()
    {
        char userChoice = ' ';
        _libraryUserInteraction.PrintMessage("Welcome to the Enchanted Library");
        _libraryUserInteraction.PrintMessage("Press any key to begin");
        _libraryUserInteraction.WaitForUser();

        do
        {
            _libraryUserInteraction.ClearScreen();            
            userChoice = GetUserChoice();

            if (_libraryActions.ContainsKey(userChoice))
            {
                _libraryUserInteraction.ClearScreen();
                _libraryActions[userChoice].Execute(_library);
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
        foreach (var item in _libraryActions)
        {
            _libraryUserInteraction.PrintMessage(item.Value.Message);
        }
    }
}