namespace FileSystemEmulator.Core.Interfaces;


public interface ICommand
{
    void Execute();
    void undo();
    string Description { get; }
}