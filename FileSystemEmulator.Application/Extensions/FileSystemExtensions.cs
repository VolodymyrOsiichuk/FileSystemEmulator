using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Application.Extensions;

public static class FileSystemExtensions
{
    public static IEnumerable<FileItem> GetLargeFiles(
        this IEnumerable<FileSystemItem> items,
        long minSize)
    {
        return items
            .OfType<FileItem>()
            .Where(x => x.Size >= minSize);
    }

    public static IEnumerable<FileItem> GetFilesByExtension(
        this IEnumerable<FileSystemItem> items,
        string extension)
    {
        return items
            .OfType<FileItem>()
            .Where(x => x.Extension == extension);
    }

    public static long GetTotalSize(
        this IEnumerable<FileSystemItem> items)
    {
        return items.Sum(x => x.GetSize());
    }

    public static IEnumerable<FileSystemItem> OrderByName(
        this IEnumerable<FileSystemItem> items)
    {
        return items.OrderBy(x => x.Name);
    }
}