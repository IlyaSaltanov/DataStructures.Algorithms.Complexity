namespace Working_code_for_practices_with_all_data_structures;

public class LinkedList
{
    public int Count;
    public Node? Head;
    public Node? Tail;

    public LinkedList()
    {
    }

    public LinkedList(int number)
    {
        Add(number);
    }

    public LinkedList(int[] massive)
    {
        for (int i = 0; i < massive.Length; i++)
            Add(massive[i]);
    }

    public void Add(int number)
    {
        var node = new Node(number);
        if (Head is null || Tail is null)
        {
            Head = node;
            Tail = node;
            Count = 1;
            return;
        }

        Tail.NextNode = node;
        Tail = node;
        Count++;
    }

    public string GetItems()
    {
        var result = "";
        var current = Head;
        while (current is not null)
        {
            result += $"{current.Value} ";
            current = current.NextNode;
        }

        return result;
    }

    public int this[int index] => FindNode(index).Value;

    private Node FindNode(int index)
    {
        if (index < 0 || index >= Count)
            throw new ArgumentOutOfRangeException(nameof(index));

        var current = Head;
        for (int i = 0; i < index; i++)
            current = current?.NextNode;

        if (current is null)
            throw new InvalidOperationException();

        return current;
    }
}
