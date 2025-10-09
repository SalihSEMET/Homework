namespace Homework;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly List<T> _entities = new List<T>();

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }

    public void Remove(T entity)
    {
        _entities.Remove(entity);
    }
}