using System.Xml.Serialization;

namespace FileSystemEmulator.Infrastructure.Serialization;

public class XmlSerializationStrategy
    : ISerializationStrategy
{
    public void Serialize<T>(T data, string path)
    {
        XmlSerializer serializer =
            new(typeof(T));

        using FileStream stream =
            new(path, FileMode.Create);

        serializer.Serialize(stream, data);
    }

    public T? Deserialize<T>(string path)
    {
        if (!File.Exists(path))
            return default;

        XmlSerializer serializer =
            new(typeof(T));

        using FileStream stream =
            new(path, FileMode.Open);

        return (T?)serializer.Deserialize(stream);
    }
}