using FileSystemEmulator.Core.Interfaces;
using FileSystemEmulator.Core.Models;


namespace FileSystemEmulator.Application.Commands;

public class MoveCommand : ICommand
{
    private readonly DirectoryItem _sourceDirectory;
    private readonly DirectoryItem _targetDirectory;
    private readonly FileSystemItem _item;

    public string Description => $"Moved {_item.Name}";

    public MoveCommand(
        DirectoryItem sourceDirectory,
        DirectoryItem targetDirectory,
        FileSystemItem item
    )
    {
        _sourceDirectory = sourceDirectory;
        _targetDirectory = targetDirectory;
        _item = item;
    }

    public void Execute()
    {
        _sourceDirectory.Remove(_item);

        _targetDirectory.AddItem(_item);
    }

    public void Undo()
    {
        _targetDirectory.Remove(_item);
        
        _sourceDirectory.AddItem(_item); 
    }
}