using FileSystemEmulator.Application.Commands;
using FileSystemEmulator.Core.Enums;
using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Tests.Commands;

public class MoveCommandTests
{
    [Fact]
    public void Execute_Should_Move_File()
    {
        DirectoryItem source = new("source");

        DirectoryItem target = new("target");

        FileItem file = new(
            "notes",
            "txt",
            FileType.Text,
            500);

        source.AddItem(file);

        MoveCommand command =
            new(source, target, file);

        command.Execute();

        Assert.DoesNotContain(file, source.Children);

        Assert.Contains(file, target.Children);
    }
}