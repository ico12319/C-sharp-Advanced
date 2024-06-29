using System;
namespace Application
{
    public class StartUp
    {

        public static void Main()
        {
            DoublyLinkedlist doubly = new();
            doubly.addFirst(2);
            doubly.addFirst(12);
            doubly.addFirst(14);
            doubly.removeLast();
            doubly.removeLast();
            doubly.removeLast();

            doubly.forEach(num => Console.WriteLine(num));
            Console.ReadKey();


        }

    }
}