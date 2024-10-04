using TheEnchantedLibrary;
using TheEnchantedLibrary.Models;

var enchantedLibrary = new Library();
var userInteraction = new LibraryConsoleUserInteraction();
var actions = new Dictionary<char, LibraryAction>() {
    {'A', new AddBook(userInteraction)},
    {'L', new ListBooks(userInteraction)},
    {'R', new RemoveBook(userInteraction)},
    {'X', new ExitApp(userInteraction)}
};
var libraryActions = new LibraryActions(actions);
var enchantedLibraryApp = new EnchantedLibraryApp(libraryActions, userInteraction, enchantedLibrary);
enchantedLibraryApp.StartApp();