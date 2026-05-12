using FileSystemEmulator.Core.Enums;


namespace FileSystemEmulator.Core.Models;

public class User
{
    public Guid Id { get; private set; }
    public string Username { get; private set; } = default!;
    public AccessRight Rights { get; private set; }

    public User(string username, AccessRight rights)
    {
        Id = Guid.NewGuid();
        Username = username;
        Rights = rights;
    }

    public override string ToString()
    {
        return $"{Username} ({Rights})";
    }
}