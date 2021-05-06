using System;
using System.Collections.Generic;

namespace SLL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            SinglyLinkedList list = new SinglyLinkedList();
            list.Add(2);
            list.Add(4);
            list.Add(5);
            // list.PrintValues();
            Console.WriteLine("find 0: " + list.Find(0));
            Console.WriteLine("find 2: " + list.Find(2));
            list.Remove();
            Console.WriteLine("after removing the last node");
            list.PrintValues();
        }

        public class SllNode
        {
            public int Value;
            public SllNode Next;
            public SllNode(int value)
            {
                Value = value;
                Next = null;
            }
        }
        public class SinglyLinkedList
        {
            public SllNode Head;
            public SinglyLinkedList()
            {
                Head = null;

            }
            public void Add(int value)
            {
                SllNode newNode = new SllNode(value);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    SllNode runner = Head;
                    while (runner.Next != null)
                    {
                        runner = runner.Next;
                    }
                    runner.Next = newNode;
                }
            }
            public void Remove()
            {
                if (Head.Next == null)
                {
                    Head = null;
                }
                else
                {
                    SllNode runner = Head;
                    SllNode runnerTwo = Head.Next;

                    while(runnerTwo.Next != null)
                    {
                        runner = runnerTwo;
                        runnerTwo = runnerTwo.Next;
                    }

                    runner.Next = null;
                    
                }
            }
            public int? Find(int value)
            {
                SllNode runner = Head;
                while (runner != null)
                {
                    if (runner.Value == value)
                    {
                        return runner.Value;
                    } 
                    runner = runner.Next;
                }
                return null;
            }
            public void PrintValues()
            {
                SllNode current = Head;
                if (current == null)
                {
                    Console.WriteLine("No nodes to print");
                }
                else 
                {
                    while (current != null)
                    {
                        Console.WriteLine("Node: " + current.Value);
                        current = current.Next;
                    }
                }
            }
        }


    }
}
