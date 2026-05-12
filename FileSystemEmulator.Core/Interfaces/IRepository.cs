namespace FileSystemEmulator.Core.Interfaces;


public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    IEnumerable<T> GetAll();
    T? GetById(Guid id);
}