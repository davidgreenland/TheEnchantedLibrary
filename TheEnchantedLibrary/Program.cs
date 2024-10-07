using TheEnchantedLibrary;
using TheEnchantedLibrary.Actions;
using TheEnchantedLibrary.Helpers;
using TheEnchantedLibrary.Models;

var enchantedLibrary = new Library();
var userInteraction = new LibraryConsoleUserInteraction();
var actions = new Dictionary<char, LibraryAction>() {
    {ActionKey.ADD_BOOK, new AddBook(userInteraction)},
    {ActionKey.LIST_BOOKS, new ListBooks(userInteraction)},
    {ActionKey.REMOVE_BOOK, new RemoveBook(userInteraction)},
    {ActionKey.EXIT_APP, new ExitApp(userInteraction)}
};
var libraryActions = new LibraryActions(actions);
var enchantedLibraryApp = new EnchantedLibraryApp(libraryActions, userInteraction, enchantedLibrary);
enchantedLibraryApp.StartApp();