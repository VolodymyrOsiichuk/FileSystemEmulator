using FileSystemEmulator.Application.Commands;
using FileSystemEmulator.Core.Enums;
using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Tests.Commands;

public class DeleteCommandTests
{
    [Fact]
    public void Execute_Should_Remove_File_From_Directory()
    {
        DirectoryItem root = new("root");

        FileItem file = new(
            "notes",
            "txt",
            FileType.Text,
            500);

        root.AddItem(file);

        DeleteCommand command =
            new(root, file);

        command.Execute();

        Assert.DoesNotContain(file, root.Children);
    }

    [Fact]
    public void Undo_Should_Restore_File_To_Directory()
    {
        DirectoryItem root = new("root");

        FileItem file = new(
            "notes",
            "txt",
            FileType.Text,
            500);

        root.AddItem(file);

        DeleteCommand command =
            new(root, file);

        command.Execute();

        command.Undo();

        Assert.Contains(file, root.Children);
    }
}