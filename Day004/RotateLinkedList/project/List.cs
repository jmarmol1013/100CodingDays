// Input: head = [1,2,3,4,5], k = 2
// Output: [4,5,1,2,3]

using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
     private Node Head;
    private Node Tail;

    public LinkedList()
    {
        Head = null;
        Tail = null;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
    }

    public void Display()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    private int GetLength()
    {
        int length = 0;
        Node current = Head;
        while (current != null)
        {
            length++;
            current = current.Next;
        }
        return length;
    }

    public void Rotate(int k)
    {       
        
        int listLen = GetLength();
        k = k % listLen;

        if(listLen == 0 || k == 0)
        {
            return;
        }

        Node current = Head;
        Node newHead = null;
        Node newTail = null;
        
        for(int i = 0; i < listLen - k - 1; i++)
        {
            current = current.Next;
        }

        newTail = current;
        newHead = current.Next;
        newTail.Next = null;


        current = newHead;
        while(current.Next != null)
        {
            current = current.Next;
        }

        current.Next = Head;
        Head = newHead;
        Tail = newTail;
    }
}

class List
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        LinkedList linkedList2 = new LinkedList();

        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Add(4);
        linkedList.Add(5);
        Console.WriteLine("Test 1");
        Console.WriteLine("Linked list:");
        linkedList.Display();
        int k = 2;
        linkedList.Rotate(k);
        Console.WriteLine($"Linked list rotate {k} times:");
        linkedList.Display();

        linkedList2.Add(0);
        linkedList2.Add(1);
        linkedList2.Add(2);
        Console.WriteLine("Linked list 2:");
        linkedList2.Display();
        k = 4;
        linkedList2.Rotate(k);
        Console.WriteLine($"Linked list rotate {k} times:");
        linkedList2.Display();
    }
}