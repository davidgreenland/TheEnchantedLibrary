namespace TheEnchantedLibrary.Models;

public class Library : ILibrary
{
    private readonly ILibraryUserInteraction _libraryUserInteraction;
    private ICollection<Book> Catalogue = [];

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