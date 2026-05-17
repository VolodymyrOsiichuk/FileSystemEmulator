using FileSystemEmulator.Core.Enums;
using FileSystemEmulator.Core.Interfaces;
using FileSystemEmulator.Core.Models;

namespace FileSystemEmulator.Application.Services;

public class AccessManager : IAccessMenager
{
    public bool HasAccess(
        User user,
        FileSystemItem item,
        AccessRight requiredRights)
    {
        return (user.Rights & requiredRights)
               == requiredRights;
    }
}