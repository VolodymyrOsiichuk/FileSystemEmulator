using FileSystemEmulator.Core.Interfaces;
using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Application.Commands;

public class DeleteCommand : ICommand
{
    private readonly DirectoryItem _parentDirectory;

    private readonly FileSystemItem _item;

    public string Description => $"Deleted {_item.Name}";

    public DeleteCommand(
        DirectoryItem parentDirectory,
        FileSystemItem item
    )
    {
        _parentDirectory = parentDirectory;
        _item = item;
    }

    public void Execute()
    {
        _parentDirectory.Remove(_item);
    }

    public void Undo()
    {
        _parentDirectory.AddItem(_item);
    }
}