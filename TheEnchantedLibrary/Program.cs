using TheEnchantedLibrary;
using TheEnchantedLibrary.Models;

var enchantedLibrary = new Library();
var userInteraction = new LibraryConsoleUserInteraction();
var actions = new Dictionary<char, LibraryAction>() {{'A', new AddBook(userInteraction)}};
var libraryActions = new LibraryActions(actions);
var enchantedLibraryApp = new EnchantedLibraryApp(libraryActions, userInteraction, enchantedLibrary);
enchantedLibraryApp.StartApp();