namespace Working_code_for_practices_with_all_data_structures;

using System.Collections;
using System.Collections.Generic;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    public int Count{ get; private set; } = 0;
    private Node _head;

    private class Node
    {
        public T Value;
        public Node? Next;

        public Node(T value){
            Value = value;
        }
    }

    public SimpleLinkedList(){}

    public SimpleLinkedList(T value){
        Push(value);
    }

    public SimpleLinkedList(IEnumerable<T> values){
        foreach (var value in values){
            Push(value); 
        }
    }
    
    public void Push(T value)
    {
        var newNode = new Node(value);
        newNode.Next = _head;
        _head = newNode;
        Count++;
    }

    public T Pop()
    {
        if (_head is null)
            throw new InvalidOperationException("Список пуст");

        var value = _head.Value;
        _head = _head.Next;
        Count--;
        return value;
    }

    public IEnumerator<T> GetEnumerator(){
        var current = _head;
        while (current != null){
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}