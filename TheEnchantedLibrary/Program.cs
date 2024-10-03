using TheEnchantedLibrary;
using TheEnchantedLibrary.Models;

var enchantedLibrary = new Library([new Book("Dusty Old Book", "Ernesto Basile", "Grandidiliomostrosous"), 
    new Book("Cricket Almanac 1924", "Rudolf Dassler", "Owzatamillionwicket")]);

var enchantedLibraryApp = new EnchantedLibraryApp(enchantedLibrary, new LibraryConsoleUserInteraction());
enchantedLibraryApp.StartApp();

enchantedLibrary.AddBook(new Book("book3", "dhdhdh", "Magic spell"));
enchantedLibraryApp.StartApp();

var bookToRemove = enchantedLibrary.GetBooks().FirstOrDefault(x => x.Title == "book");
Console.WriteLine(bookToRemove?.Title ?? "Not Found");