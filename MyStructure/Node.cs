namespace Working_code_for_practices_with_all_data_structures;

public class Node
{
    public int Value { get; private set; }
    public Node? NextNode { get; set; }
    public Node? PreviosNode { get; set; }

    public Node(int number)
    {
        Value = number;
    }
}
