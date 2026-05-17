using FileSystemEmulator.Application.Commands;
using FileSystemEmulator.Application.Menagers;
using FileSystemEmulator.Core.Models;
using FileSystemEmulator.Core.Interfaces;


namespace FileSystemEmulator.Application.Services;

public class FileSystemService
{
    private readonly UndoRedoMenager _manager = new();

    public void ExecuteCommand(ICommand command)
    {
        _manager.ExecuteCommand(command);
    }

    public void Undo()
    {
        _manager.Undo();
    }

    public void Redo()
    {
        _manager.Redo();
    }
}