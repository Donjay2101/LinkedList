using System;

namespace LinkedList
{

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        Node _head = null;
        Node newNode = null;
        public void Insert(int value)
        {
            if(_head == null)
            {
                _head = new Node();
                _head.Data = value;
                _head.Next = null;
            }
            else
            {
                newNode = new Node();
                newNode.Data = value;
                newNode.Next = _head;
                _head = newNode;
            }
        }


        public Node Traverse( bool isSearch =false, int search_value =0) 
        {
            var _nextNode = _head;
            int count = 1;
            while(_nextNode !=null)
            {
                if(isSearch)
                {
                    if(_nextNode.Data == search_value)
                    {
                        Console.WriteLine($"value found in linked list at node {count}");
                        break;
                    }
                }
                else
                {
                    Console.Write($"{_nextNode.Data} ");
                    _nextNode = _nextNode.Next;
                }
                count++;
                
            }
            return _nextNode;
        }


        public void DeleteStart()
        {
            _head = _head.Next; 
        }


        public void DeleteEnd()
        {
            var _next = new Node();
            var _secondLast = new Node();
            _next = _head;
            
            while (_next.Next != null)
            {
                _secondLast = _next;
                _next = _next.Next;
            }
            _secondLast.Next = null;
        }

        public void Instructions()
        {
            Console.WriteLine("\n------------------- welcome to linkedlist program--------------------\n");
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine("Press 1 to insert data in linked list");
            Console.WriteLine("Press 2 to Iterate through linked list");
            Console.WriteLine("Press 3 to search data in linked list");
            Console.WriteLine("Press 4 to delete data in linked list from start");
            Console.WriteLine("Press 5 to delete data in linked list from last");
            Console.WriteLine("Press 6 to delete data in linked list from any point");
        }

        public void InovkeChoice(int choice)
        {
            switch(choice)
            {
                case 1:
                    int valu;
                    Console.WriteLine("Enter value to put in linked list");
                    valu = Convert.ToInt32(Console.ReadLine());
                    Insert(valu);
                    break;
                case 2:
                    Traverse();
                    break;
                case 3:
                    Console.WriteLine("enter value which you want to search");
                    var value = Convert.ToInt32(Console.ReadLine());
                    Traverse(true,value);
                    break;
                case 4:
                    DeleteStart();
                    Console.WriteLine("node has been deleted from start.");
                    Traverse();
                    break;
                case 5:
                    DeleteEnd();
                    Console.WriteLine("node has been deleted from start.");
                    Traverse();
                    break;
                default:
                    Console.WriteLine("not a valid choice");
                    break;
            }
            Console.WriteLine("\n");
        }


    }
}
