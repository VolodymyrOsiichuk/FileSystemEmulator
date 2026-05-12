namespace FileSystemEmulator.Core.Models;

public class DirectoryItem : FileSystemItem
{
    private readonly List<FileSystemItem> _children = [];

    public IReadOnlyCollection<FileSystemItem> Children => _children.AsReadOnly();

    public DirectoryItem(string name) : base(name){}

    public void AddItem(FileSystemItem item)
    {
        _children.Add(item);

        item.Parent = this;
    }

    public void Remove(FileSystemItem item)
    {
        _children.Remove(item);
    }

    public override long GetSize()
    {
        return _children.Sum(x => x.GetSize());
    }

    public override string GetInfo()
    {
        return $"DIR: {Name} ({_children.Count}) items";
    }
}