namespace Tusk_2;
using System.Collections.Generic;
using System.Linq;

public delegate bool Criteria<T>(T item);

public class Repository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public IEnumerable<T> Find(Criteria<T> criteria)
    {
        return items.Where(criteria.Invoke);
    }
}
