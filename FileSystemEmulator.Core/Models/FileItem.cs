using FileSystemEmulator.Core.Enums;


namespace FileSystemEmulator.Core.Models;

public class FileItem : FileSystemItem
{
    public FileType FileType { get; private set; }
    public string Extension { get; private set; } = default!;
    public long Size { get; private set; }
    public string Сontent { get; private set; } = default!;

    public FileItem(
        string name,
        string extension,
        FileType fileType,
        long size,
        string content = ""
    ) : base(name)
    {
        Extension = extension;
        FileType = fileType;
        Size = size;
        Сontent = content;
    }

    public override long GetSize()
    {
        return Size;
    }

    public override string GetInfo()
    {
        return $"FILE: {Name}.{Extension} ({Size}) bytes";
    }
}