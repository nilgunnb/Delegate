class CustomList<T> where T : class
{
    private T[] List;

    public CustomList()
    {
        List = new T[0];
    }

    public void Add(T item)
    {
        Array.Resize (ref List, List.Length+1);

        List[List.Length-1] = item;
    }

    public T Find(Predicate<T> func)
    {
        foreach (T item in List)
        {
            if (func(item))
            {
                return item;
            }
        }
        return null;
    }
}