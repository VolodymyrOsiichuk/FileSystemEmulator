using FileSystemEmulator.Core.Enums;
using FileSystemEmulator.Core.Models;
using FileSystemEmulator.Infrastructure.Serialization;

DirectoryItem root = new("root");

root.AddItem(new FileItem(
    "notes",
    "txt",
    FileType.Text,
    500));

JsonSerializationStrategy serializer = new();

serializer.Serialize(root, "filesystem.json");

Console.WriteLine("Saved.");