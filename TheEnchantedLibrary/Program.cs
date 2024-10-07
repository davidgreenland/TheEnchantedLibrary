using TheEnchantedLibrary.Actions;
using TheEnchantedLibrary.Helpers;
using TheEnchantedLibrary.Models;
using TheEnchantedLibrary.Services;

var enchantedLibrary = new Library();
var userInteraction = new LibraryConsoleUserInteraction();

var actions = new Dictionary<char, LibraryAction>() {
    {ActionKey.ADD_BOOK, new AddBook(userInteraction)},
    {ActionKey.LIST_BOOKS, new ListBooks(userInteraction, new Dictionary<char, LibraryAction>
        {
            { SortKey.BY_AUTHOR, new ListBooksSortedByAuthor(userInteraction) },
            { SortKey.BY_TITLE, new ListBooksSortedByTitle(userInteraction) },
            { SortKey.BY_ID, new ListBooksSortedById(userInteraction) },
        })
    },
    {ActionKey.REMOVE_BOOK, new RemoveBook(userInteraction)},
    {ActionKey.SEARCH, new Search(userInteraction)},
    {ActionKey.EXIT_APP, new ExitApp(userInteraction)}
};

var libraryActions = new LibraryActions(actions);
var enchantedLibraryApp = new EnchantedLibraryApp(libraryActions, userInteraction, enchantedLibrary);
enchantedLibraryApp.StartApp();