using System.Collections.Generic;
namespace Task3;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> items = new();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public long GetTotalSize()
    {
        return items.Count();
    }
}