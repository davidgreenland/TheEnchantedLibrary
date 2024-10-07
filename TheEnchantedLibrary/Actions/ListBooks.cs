using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class ListBooks : LibraryAction
{
    private readonly ILibraryUserInteraction _libraryUserInteraction;
    private readonly Dictionary<char, LibraryAction> _secondaryActions;
    public override string Message { get; } = "[L]ist all books.";

    public ListBooks(ILibraryUserInteraction libraryUserInteraction, Dictionary<char, LibraryAction> secondaryActions)
    {
        _libraryUserInteraction = libraryUserInteraction;
        _secondaryActions = secondaryActions;
    }

    public override void Execute(ILibrary library)
    {
        var books = library.GetBooks();
        char userChoice;

        _libraryUserInteraction.ClearScreen();
        _libraryUserInteraction.PrintBooks(books);
        userChoice = _libraryUserInteraction.SortListOrContinue();

        while (_secondaryActions.ContainsKey(userChoice))
        {
            _secondaryActions[userChoice].Execute(library);
            userChoice = _libraryUserInteraction.SortListOrContinue();
        };
    }
}