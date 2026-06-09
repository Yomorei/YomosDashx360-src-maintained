using System;
using System.Collections;
using System.Collections.Generic;

 internal sealed class _003C_003Ez__ReadOnlyArray<T> : IList<T>, IReadOnlyList<T>, IList
{
    private readonly T[] _items;

    public _003C_003Ez__ReadOnlyArray(params T[] items)
    {
        _items = items ?? Array.Empty<T>();
    }

    public int Count => _items.Length;

    public bool IsReadOnly => true;

    public bool IsFixedSize => true;

    public bool IsSynchronized => false;

    public object SyncRoot => this;

    public T this[int index]
    {
        get => _items[index];
        set => throw new NotSupportedException();
    }

    object? IList.this[int index]
    {
        get => _items[index];
        set => throw new NotSupportedException();
    }

    public bool Contains(T item)
    {
        return Array.IndexOf(_items, item) >= 0;
    }

    public bool Contains(object? value)
    {
        return value is T typed && Contains(typed);
    }

    public int IndexOf(T item)
    {
        return Array.IndexOf(_items, item);
    }

    public int IndexOf(object? value)
    {
        return value is T typed ? IndexOf(typed) : -1;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        Array.Copy(_items, 0, array, arrayIndex, _items.Length);
    }

    public void CopyTo(Array array, int index)
    {
        Array.Copy(_items, 0, array, index, _items.Length);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_items).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T item)
    {
        throw new NotSupportedException();
    }

    public int Add(object? value)
    {
        throw new NotSupportedException();
    }

    public void Insert(int index, T item)
    {
        throw new NotSupportedException();
    }

    public void Insert(int index, object? value)
    {
        throw new NotSupportedException();
    }

    public bool Remove(T item)
    {
        throw new NotSupportedException();
    }

    public void Remove(object? value)
    {
        throw new NotSupportedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotSupportedException();
    }

    public void Clear()
    {
        throw new NotSupportedException();
    }
}
