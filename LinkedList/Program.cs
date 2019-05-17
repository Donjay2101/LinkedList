using System;

namespace LinkedList
{
    class Program
    {

        static readonly LinkedList _list = new LinkedList();

        static void Main(string[] args)
        {

            int choice;
            do
            {
                _list.Instructions();
                choice = Convert.ToInt32(Console.ReadLine());
                _list.InovkeChoice(choice);
            } while (choice != 0);
            
        }
    }
}
