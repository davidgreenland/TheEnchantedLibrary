﻿namespace TheEnchantedLibrary.Models;

public class LibraryActions
{
    public Dictionary<char, LibraryAction> Actions { get; private set; }

    public LibraryActions(Dictionary<char, LibraryAction> actions)
    {
        Actions = actions;
    }

    public void UseAction(char key, Library library)
    {
        Actions[key].Execute(library);
    }
}