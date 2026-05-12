namespace FileSystemEmulator.Core.Models;

public class DiskVolume
{
    public string Name { get; private set; } = default!;
    public long Capacity { get; private set; }
    public DirectoryItem RootDirectory  { get; private set; }

    public DiskVolume(string name, long capacity)
    {
        Name = name;
        Capacity = capacity;

        RootDirectory = new DirectoryItem("root");
    }

    public long GetUsedSpace()
    {
        return RootDirectory.GetSize();
    }

    public long GetFreeSpace()
    {
        return Capacity - GetUsedSpace();
    }
}