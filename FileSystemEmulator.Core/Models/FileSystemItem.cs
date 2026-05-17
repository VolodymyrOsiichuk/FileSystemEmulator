using System.Text.Json.Serialization;
namespace FileSystemEmulator.Core.Models;


public abstract class FileSystemItem
{
    public Guid id { get; private set; }
    public string Name { get; private set; } = default!;
    public DateTime CreatedAt { get; private set; }
    [JsonIgnore]
    public DirectoryItem? Parent { get; set; }

    protected FileSystemItem(string name)
    {
        id = Guid.NewGuid();
        Name = name;
        CreatedAt = DateTime.Now;
    }

    public void Rename(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Invalid name.");

        Name = name;
    }

    public abstract long GetSize();

    public virtual string GetInfo()
    {
        return Name;
    }

    public override string ToString()
    {
        return GetInfo();
    }
}