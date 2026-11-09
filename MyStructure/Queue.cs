using System.Runtime.CompilerServices;

namespace Working_code_for_practices_with_all_data_structures;

public class Queue
{
    public Node Head;
    public Node Tail;
    private List<int>? _items = new List<int>();
    public int Count;
    public Queue(int[] massive)
    {
        var temp = new Node[massive.Length];
        for (int i = 0; i < massive.Length; i++)
        {
            temp[i] = new Node(massive[i]);
            temp[i].PreviosNode = i != 0 ? temp[i - 1] : null;
        }
        Head = temp[0];
        Tail = temp[temp.Length-1];
    }

    public void Add(int number)
    {
        var temp = new Node(number);
        if (Head == null)
        {
            Head = temp;
            Tail = Head;
            Count++;
        }
        else
        {
            Tail.NextNode = temp;
            Tail = temp;
            Count++;
        }
    }

    public string GetItems()
    {
        var current = Tail;
        while (current is not null && _items != null)
        {
            _items.Add(current.Value);
            current = current.PreviosNode;
        }
        string result = "";
        if (_items != null)
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                result += $"{_items[i]} ";
            }
            return result;
        }
        
        return "Что-то пошло не так!";
    }

    public void Remove(int count)
    {
        if (count > 0 && count <= Count)
        {
            for (int i = 0; i < count; i++)
            {
                Head = Head.NextNode;
                Count--;
            }
        }
        else
        {
            Console.WriteLine("Невозможно удалить элементы!");
        }
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }
}
