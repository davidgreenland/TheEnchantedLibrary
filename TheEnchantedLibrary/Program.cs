using TheEnchantedLibrary.Models;

var enchantedLibrary = new Library([new Book("Dusty Old Book", "Ernesto Basile", "Grandidiliomostrosous"), 
    new Book("Cricket Almanac 1924", "Rudolf Dassler", "Owzatamillionwicket")], new LibraryConsoleUserInteraction());

enchantedLibrary.ListBooks();