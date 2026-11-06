



using Working_code_for_practices_with_all_data_structures;

var n5 = new Node(5);
var n12 = new Node(12);

Console.WriteLine(n5.Value);

n5.NextNode = n12;
Console.WriteLine(n5.NextNode);
Console.WriteLine(n5.NextNode.Value);


var q = new Queue(new[] {4, 4, 5, 1, 6, 7});
Console.WriteLine(q.Head.Value);
Console.WriteLine(q.Tail.Value);
Console.WriteLine(q.GetItems());