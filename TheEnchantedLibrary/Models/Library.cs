namespace TheEnchantedLibrary.Models;

public class Library
{
    private ICollection<Book> Catalogue = [];
    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public Library(List<Book> books, ILibraryUserInteraction libraryUserInteraction)
    {
        _libraryUserInteraction = libraryUserInteraction;
        Catalogue = books;
    }

    public Library(ILibraryUserInteraction libraryUserInteraction)
    {
        _libraryUserInteraction = libraryUserInteraction;
    }

    public void ListBooks()
    {
        _libraryUserInteraction.PrintBooks(this);
    }
}