namespace FileSystemEmulator.Core.Enums;

[Flags]
public enum AccessRight
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 3,
    Delete = 4,
    FullControl = Read | Write | Execute | Delete
}