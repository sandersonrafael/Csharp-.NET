namespace GenericsEx;

/* Generic Class */
public class PrintService<T>
{
    private T[] _values = new T[10];
    private int _count = 0;

    public void AddValue(T value)
    {
        if (_count >= _values.Length) throw new InvalidOperationException("PrintService is full");
        _values[_count] = value;
        _count++;
    }

    public T First()
    {
        if (_count == 0) throw new InvalidOperationException("PrintService is empty");
        return _values[0];
    }

    public void Print()
    {
        Console.Write('[');
        for (int i = 0; i < _count; i++)
        {
            Console.Write(_values[i]);
            if (i < (_count - 1)) Console.Write(", ");
        }
        Console.Write(']');
    }
}
