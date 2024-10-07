namespace TheEnchantedLibrary.Models;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string Spell {  get; private set; }

    public Book(int id, string title, string author, string spell)
    {
        Id = id;
        Title = title;
        Author = author;
        Spell = spell;      
    }
}