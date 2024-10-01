namespace TheEnchantedLibrary.Models;

public class Book
{
    public static int CountOfBooks { get; private set; }
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string Spell {  get; private set; }

    public Book(string title, string author, string spell)
    {
        ++CountOfBooks;
        Id = CountOfBooks;
        Title = title;
        Author = author;
        Spell = spell;      
    }
}
