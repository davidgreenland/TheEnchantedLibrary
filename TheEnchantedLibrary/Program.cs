using TheEnchantedLibrary.Models;

var book1 = new Book(spell: "Grandidiliomostrosous", title: "Dusty Old Book", author: "Ernesto Basile");
var book2 = new Book("Cricket Almanac 1924", "Rudolf Dassler", "Owzatamillionwicket");
var libraryStartsEmpty = new Library(new LibraryConsoleUserInteraction());
var libraryStartsWithBooks = new Library([book1, book2], new LibraryConsoleUserInteraction());

libraryStartsWithBooks.ListBooks();
libraryStartsWithBooks.AddBook();
libraryStartsWithBooks.ListBooks();