using FileSystemEmulator.Application.Commands;
using FileSystemEmulator.Application.Menagers;
using FileSystemEmulator.Core.Models;
using FileSystemEmulator.Core.Enums;


DirectoryItem root = new("root");

DirectoryItem folder = new("folder");

FileItem file = new(
    "notes",
    "txt",
    FileType.Text,
    500);

root.AddItem(file);
root.AddItem(folder);

Console.WriteLine("Before copy: ");
foreach(var child in root.Children)
{
    Console.WriteLine(child);
}

UndoRedoMenager manager = new();

CopyCommand copyCommand = new(root, file);

manager.ExecuteCommand(copyCommand);

Console.WriteLine("After copy: ");
foreach(var child in root.Children)
{
    Console.WriteLine(child);
}

manager.Undo();
Console.WriteLine("After undo: ");
foreach(var child in root.Children)
{
    Console.WriteLine(child);
}

manager.Redo();
Console.WriteLine("After redo: ");
foreach(var child in root.Children)
{
    Console.WriteLine(child);
}

