using FileSystemEmulator.Core.Enums;
using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Core.Interfaces;

public interface IAccessMenager
{
    bool HasAccess(
        User user,
        FileSystemItem item,
        AccessRight requiredRights
    );
}
