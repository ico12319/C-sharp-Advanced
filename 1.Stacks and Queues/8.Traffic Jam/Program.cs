using System;
using System.Collections.Generic;

class Program { 

    static void Main(string[] args)
    {
        var carsToGo = int.Parse(Console.ReadLine());
        var count = 0;

        var queue = new Queue<string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
                break;

            if (input!="green")
            {
                queue.Enqueue(input);
            }
            else if (input == "green")
            {
                for (int i = 0; i < carsToGo; i++)
                {
                    if(queue.Count != 0)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
            }
        }
        Console.WriteLine($"{count} cars passed the crossroad.");
        Console.ReadKey();

    }

    

}