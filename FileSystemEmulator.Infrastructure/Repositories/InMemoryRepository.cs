using FileSystemEmulator.Core.Interfaces;

namespace FileSystemEmulator.Infrastructure.Repositories;

public class InMemoryRepository<T> : IRepository<T>
    where T : class
{
    private readonly List<T> _items = [];

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public T? GetById(Guid id)
    {
        return _items
            .FirstOrDefault(x =>
            {
                dynamic item = x;

                return item.Id == id;
            });
    }
}