using TheEnchantedLibrary.Models;

var book1 = new Book(spell: "Grandidiliomostrosous", title: "Dusty Old Book", author: "Ernesto Basile");
var book2 = new Book("Cricket Almanac 1924", "Rudolf Dassler", "Owzatamillionwicket");
var libraryStartsEmpty = new Library();
var libraryStartsWithBooks = new Library([book1, book2]);

Console.WriteLine("The following books are housed in the " + 
    nameof(libraryStartsWithBooks));
foreach (var book in libraryStartsWithBooks.Catalogue)
{

    Console.WriteLine(book.Title);
}