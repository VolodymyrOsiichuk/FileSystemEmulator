using FileSystemEmulator.Core.Models;
using FileSystemEmulator.Core.Enums;

namespace FileSystemEmulator.Application.Factories;


public static class FileSystemItemFactory
{
    public static FileItem CreateFile(
        string name,
        string extension,
        long size,
        string content = ""
    )
    {
        return new FileItem(
            name,
            extension,
            FileType.Text,
            size,
            content
        );
    }

    public static DirectoryItem CreateDirectory(string name)
    {
        return new DirectoryItem(name);
    }
}