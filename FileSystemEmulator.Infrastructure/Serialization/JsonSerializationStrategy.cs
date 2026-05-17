using System.Text.Json;

namespace FileSystemEmulator.Infrastructure.Serialization;

public class JsonSerializationStrategy
    : ISerializationStrategy
{
    public void Serialize<T>(T data, string path)
    {
        JsonSerializerOptions options = new()
        {
            WriteIndented = true
        };

        string json =
            JsonSerializer.Serialize(data, options);

        File.WriteAllText(path, json);
    }

    public T? Deserialize<T>(string path)
    {
        if (!File.Exists(path))
            return default;

        string json = File.ReadAllText(path);

        return JsonSerializer.Deserialize<T>(json);
    }
}