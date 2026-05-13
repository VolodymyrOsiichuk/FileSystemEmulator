namespace FileSystemEmulator.Core.Interfaces;


public interface ICommand
{
    void Execute();
    void Undo();
    string Description { get; }
}