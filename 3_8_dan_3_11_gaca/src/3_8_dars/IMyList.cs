namespace _3_8_dars;

internal interface IMyList<T>
{
    public bool Add(T num);
    public bool RemoveAll(T num);
    public bool Remove(T num);
    public bool Contains(T num);
    public int IndexOf(T num);
    public bool RemoveAt(int index);
    public int GetById(int index);
    public void DisplayElements();
}