using FileSystemEmulator.Core.Interfaces;
using FileSystemEmulator.Core.Models;


namespace FileSystemEmulator.Application.Commands;


public class RenameCommand : ICommand
{
    public readonly FileSystemItem _item;

    private string _newName = default!;
    private string _oldName = string.Empty;

    public string Description => $"Rename {_item.Name}";

    public RenameCommand(
        FileSystemItem item,
        string newName
    )
    {
        _item = item;
        _newName = newName;
    }

    public void Execute()
    {
        _oldName = _item.Name;

        _item.Rename(_newName);
    }

    public void Undo()
    {
        _item.Rename(_oldName);
    }
}