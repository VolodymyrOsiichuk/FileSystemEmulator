using FileSystemEmulator.Core.Enums;
using FileSystemEmulator.Core.Interfaces;
using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Application.Services;

public class FileSystemProxy
{
    private readonly FileSystemService _fileSystemService;

    private readonly IAccessMenager _accessManager;

    public FileSystemProxy(
        FileSystemService fileSystemService,
        IAccessMenager accessManager)
    {
        _fileSystemService = fileSystemService;
        _accessManager = accessManager;
    }

    public void ExecuteCommand(
        User user,
        FileSystemItem item,
        AccessRight requiredRights,
        ICommand command)
    {
        bool hasAccess = _accessManager.HasAccess(
            user,
            item,
            requiredRights);

        if (!hasAccess)
        {
            throw new UnauthorizedAccessException(
                $"User {user.Username} has no permission.");
        }

        _fileSystemService.ExecuteCommand(command);
    }

    public void Undo()
    {
        _fileSystemService.Undo();
    }

    public void Redo()
    {
        _fileSystemService.Redo();
    }
}