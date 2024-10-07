using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class AddBook : LibraryAction
{
    public override string Message { get; } = "[A]dd a book";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public AddBook(ILibraryUserInteraction libraryUserInteraction)
    {
        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        _libraryUserInteraction.PrintMessage($"Add a book to the library.{Environment.NewLine}" );

        var name = _libraryUserInteraction.ReadInput("Enter the name of the book: ");
        var author = _libraryUserInteraction.ReadInput("Enter the author: ");
        var spell = _libraryUserInteraction.ReadInput("Add a magic spell: ");

        var newBook = library.AddBook(name, author, spell);
        _libraryUserInteraction.ClearScreen();
        _libraryUserInteraction.PrintMessage($"The book, '{newBook.Title}' has been added");
        _libraryUserInteraction.WaitForUser();
    }
}