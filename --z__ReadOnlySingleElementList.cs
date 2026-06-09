using System;
using System.Collections;
using System.Collections.Generic;

 internal sealed class _003C_003Ez__ReadOnlySingleElementList<T> : IList<T>, IReadOnlyList<T>, IList
{
    private readonly T _item;

    public _003C_003Ez__ReadOnlySingleElementList(T item)
    {
        _item = item;
    }

    public int Count => 1;

    public bool IsReadOnly => true;

    public bool IsFixedSize => true;

    public bool IsSynchronized => false;

    public object SyncRoot => this;

    public T this[int index]
    {
        get
        {
            if (index != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return _item;
        }
        set => throw new NotSupportedException();
    }

    object? IList.this[int index]
    {
        get => this[index];
        set => throw new NotSupportedException();
    }

    public bool Contains(T item)
    {
        return EqualityComparer<T>.Default.Equals(_item, item);
    }

    public bool Contains(object? value)
    {
        return value is T typed && Contains(typed);
    }

    public int IndexOf(T item)
    {
        return Contains(item) ? 0 : -1;
    }

    public int IndexOf(object? value)
    {
        return value is T typed ? IndexOf(typed) : -1;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        array[arrayIndex] = _item;
    }

    public void CopyTo(Array array, int index)
    {
        array.SetValue(_item, index);
    }

    public IEnumerator<T> GetEnumerator()
    {
        yield return _item;
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
