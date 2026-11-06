using System.Runtime.InteropServices;

namespace Working_code_for_practices_with_all_data_structures;

public unsafe class Array : IDisposable
{
    private int* _items;
    private bool _freed;

    public int Length { get; }

    public Array(int length)
    {
        if (length < 0)
            throw new ArgumentOutOfRangeException(nameof(length));

        Length = length;
        if (length == 0)
            return;

        _items = (int*)NativeMemory.AllocZeroed((nuint)length, (nuint)sizeof(int));
    }

    public int this[int index]
    {
        get
        {
            ValidateIndex(index);
            return *(_items + index);
        }
        set
        {
            ValidateIndex(index);
            *(_items + index) = value;
        }
    }

    public void Dispose()
    {
        FreeMemory();
        GC.SuppressFinalize(this);
    }

    ~Array()
    {
        FreeMemory();
    }

    private void FreeMemory()
    {
        if (_freed)
            return;

        if (_items != null)
            NativeMemory.Free(_items);

        _items = null;
        _freed = true;
    }

    private void ValidateIndex(int index)
    {
        if (_freed)
            throw new ObjectDisposedException(nameof(Array));

        if (index < 0 || index >= Length)
            throw new ArgumentOutOfRangeException(nameof(index));
    }
}
