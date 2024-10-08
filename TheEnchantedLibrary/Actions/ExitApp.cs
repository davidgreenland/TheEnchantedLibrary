﻿using TheEnchantedLibrary.Models.Interfaces;
using TheEnchantedLibrary.Services.Interfaces;

namespace TheEnchantedLibrary.Actions;

public class ExitApp : LibraryAction
{
    public override string Message { get; } = "E[x]it application";

    private readonly ILibraryUserInteraction _libraryUserInteraction;

    public ExitApp(ILibraryUserInteraction libraryUserInteraction)
    {

        _libraryUserInteraction = libraryUserInteraction;
    }

    public override void Execute(ILibrary library)
    {
        _libraryUserInteraction.PrintMessage("Goodbye :)");
        _libraryUserInteraction.WaitForUser();
    }
}