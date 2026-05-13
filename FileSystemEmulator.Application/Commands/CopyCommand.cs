using FileSystemEmulator.Core.Interfaces;
using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Application.Commands;


public class CopyCommand : ICommand
{
    private readonly DirectoryItem _targetDirectory;
    private readonly FileItem _originalFile;
    private FileItem? _copiedFile;

    public string Description => $"Copied {_originalFile.Name}";

    public CopyCommand(
        DirectoryItem targetDirectory,
        FileItem originalFile
    )
    {
       _targetDirectory = targetDirectory;
       _originalFile = originalFile; 
    }

    public void Execute()
    {
        _copiedFile = new FileItem(
            _originalFile.Name + "_copy",
            _originalFile.Extension,
            _originalFile.FileType,
            _originalFile.Size,
            _originalFile.Content
        );

        _targetDirectory.AddItem(_copiedFile);
    }

    public void Undo()
    {   
        if(_copiedFile is not null)
            _targetDirectory.Remove(_copiedFile);
    }
}