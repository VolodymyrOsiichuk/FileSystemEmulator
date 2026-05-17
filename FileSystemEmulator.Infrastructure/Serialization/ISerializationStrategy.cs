namespace FileSystemEmulator.Infrastructure.Serialization;

public interface ISerializationStrategy
{
    void Serialize<T>(T data, string path);

    T? Deserialize<T>(string path);
}