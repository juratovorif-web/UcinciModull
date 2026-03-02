using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_dars;

internal class MyList<T> : IMyList<T>
{
    private T[] _items;
    private int arrIndex = 0;
    public int Capacity
    {
        get { return _items.Length; }
    }

    public int Count
    {
        get { return arrIndex; }
    }
    public MyList(int capacity = 4)
    {
        _items = new T[capacity];
    }
    public bool Add(T item)
    {
        if (arrIndex >= Capacity)
        {
            DoubleCapacity();
        }

        _items[arrIndex] = item;
        arrIndex++;

        return true;
    }

    private void DoubleCapacity()
    {
        T[] newArr = new T[Capacity * 2];
        for (var i = 0; i < Capacity; i++)
        {
            newArr[i] = _items[i];
        }
        _items = newArr;
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public T GetById(T index)
    {
       
    }

    public int IndexOf(T item)
    {
        for (var i = 0; i < Capacity; i++)
        {
            if (Equals(_items[i],item))
            {
                return i;
            }
        }

        return -1;
    }

    public bool Remove(T item)
    {
       
        var index = IndexOf(item);
        if(index == -1)
        {
            return false;
        }

        for(var i = index;i < arrIndex - 1;i++)
        {
           _items[i] = _items[i + 1];
        }
         arrIndex--;
         return true;
    }

       

    public bool RemoveAll(T item)
    {
        bool removed = false;
        for(var i = 0; i < arrIndex;i++)
        {
            if(Equals(_items[i],item))
            {
                
            }
        }
    }

    public bool RemoveAt(T index)
    {
        throw new NotImplementedException();
    }

    public void DisplayElements()
    {
        for(var i = 0; i < arrIndex;i++)
        {
            Console.WriteLine(_items[i] + " ");
        }
    }
}
