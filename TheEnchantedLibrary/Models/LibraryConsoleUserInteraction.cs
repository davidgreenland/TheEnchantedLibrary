﻿namespace TheEnchantedLibrary.Models;

public class LibraryConsoleUserInteraction : ILibraryUserInteraction
{
    public void PrintBooks(Library library)
    {
        Console.WriteLine($"Here is a list of the books in the library");
        var tableHeader = String.Format("{0,4} | {1,-40} | {2,-20} | {3}", "ID", "Title", "Author", "Spell");
        Console.WriteLine(tableHeader);
        Console.WriteLine(String.Format("{0,4} | {1,-40} | {2,-20} | {3}", new string('-', 4), new string('-', 40), new string('-', 20), new string('-', 30)));
        foreach (var book in library.Catalogue)
        {
            var tableRow = String.Format("{0,4} | {1,-40} | {2,-20} | {3}", book.Id, book.Title,  book.Author, book.Spell);
            Console.WriteLine(tableRow);
        }
        Console.WriteLine();
    }
}