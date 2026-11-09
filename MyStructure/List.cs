namespace Working_code_for_practices_with_all_data_structures;

public class List
{
    private const int InitialCapacity = 4;

    public int Count;
    private int[] _items;

    public List()
    {
        _items = new int[InitialCapacity];
    }

    public List(int number) : this()
    {
        Add(number);
    }

    public List(int[] massive) : this()
    {
        for (int i = 0; i < massive.Length; i++)
            Add(massive[i]);
    }

    public void Add(int number)
    {
        EnsureCapacity();
        _items[Count] = number;
        Count++;
    }

    public string GetItems()
    {
        var result = "";
        for (int i = 0; i < Count; i++)
            result += $"{_items[i]} ";

        return result;
    }

    public int this[int index]
    {
        get => ReadAt(index);
        set => WriteAt(index, value);
    }

    private void EnsureCapacity()
    {
        if (Count < _items.Length)
            return;

        Grow();
    }

    private void Grow()
    {
        var newCapacity = _items.Length == 0 ? InitialCapacity : _items.Length * 2;
        var grown = new int[newCapacity];
        CopyTo(grown);
        _items = grown;
    }

    private void CopyTo(int[] destination)
    {
        for (int i = 0; i < Count; i++)
            destination[i] = _items[i];
    }

    private int ReadAt(int index)
    {
        ValidateIndex(index);
        return _items[index];
    }

    private void WriteAt(int index, int value)
    {
        ValidateIndex(index);
        _items[index] = value;
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= Count)
            throw new ArgumentOutOfRangeException(nameof(index));
    }
}
