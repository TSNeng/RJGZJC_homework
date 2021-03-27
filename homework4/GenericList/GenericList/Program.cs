using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            GenericList<int> intlist = new GenericList<int>();
            for(int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            int max = intlist.Head.Data;
            int min = intlist.Head.Data;
            intlist.Traverse(s => Console.WriteLine(s));
            intlist.Traverse(s => max = (s > max) ? s : max);
            intlist.Traverse(s => min = (s < min) ? s : min);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void Traverse(Action<T> func)
        {
            Node<T> p = head;
            while(p != null)
            {
                T data = p.Data;
                func(data);
                p = p.Next;
            }
        }
    }
}
