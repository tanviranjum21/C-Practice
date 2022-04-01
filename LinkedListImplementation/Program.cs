using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    public class Node
    {
        public T Data;
        public Node Next;
        //constructor
        public Node(T Data)
        {
            this.Data = Data;
        }

    }

    public Node root;
    public LinkedList()
    {
        root = null;
    }
    public bool IsEmpty()
    {
        return root == null;
    }

    public T Getroot()
    {
        if(root != null)
        {
            return root.Data;
        }
        return default(T);
    }

    public T GetCurrent()
    {
        if(root == null)
        {
            return default(T);
        }
        else
        {
            Node temporary = root;
            while(temporary.Next != null)
            {
                temporary = temporary.Next;
            }
            return temporary.Data;
        }

    }

    public void Add(T Data)
    {
        if(IsEmpty())
        {
            //If the list is empty, insert the node at the beginning
            root = new Node(Data);
            return;
        }
        Node temporary = root;
        while(temporary.Next != null)
        {
            temporary = temporary.Next;
        }
        temporary.Next = new Node(Data);
            return;
    }

    public override String ToString()
    {
        String res = "";
        Node temporary = root;
        while (temporary != null)
        {
            res += temporary.Data.ToString();
            if(temporary.Next != null)
            {
                res += ",";
            }
            temporary = temporary.Next;
        }
        return res;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node node = this.root;
        while (node != null)
        {
            yield return node.Data;
            node = node.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

}

class Implementation
{
    static void Main(string[] args)
    {
        LinkedList<String> first = new LinkedList<String>();
        first.Add("10");
        first.Add("20");
        first.Add("hello");
        Console.WriteLine(first.Getroot());
        Console.WriteLine(first.GetCurrent());
        LinkedList<int> Second = new LinkedList<int>();
        Second.Add(10);
        Second.Add(20);
        Second.Add(30);
        Console.WriteLine(Second.Getroot());
        Console.WriteLine(Second.GetCurrent());

    }

}
