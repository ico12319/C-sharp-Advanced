using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        fillStack(stack);


        while (true)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var main = input[0];

            if(main == "end")
            {
                break;
            }

            else if(main == "Add")
            {
                int num1 = int.Parse(input[1]);
                int num2 = int.Parse(input[2]);
                addNums(stack, num1, num2);
            }
            else if(main == "Remove")
            {
                int count = int.Parse(input[1]);
                if(stack.Count > count)
                {
                    removeElements(stack, count);
                }
            }
        }

        Console.WriteLine("Sum: {0}",findSum(stack));
        Console.ReadKey();

    }
    

    static void addNums(Stack<int> stack,int n1,int n2)
    {
        stack.Push(n1);
        stack.Push(n2);
    }

    static void removeElements(Stack<int> stack,int elToDel)
    {
        while (elToDel != 0)
        {
            stack.Pop();
            elToDel--;
        }
    }

    static int findSum(Stack<int> stack)
    {
        var sum = 0;
        foreach (var item in stack)
        {
            sum += item;
        }

        return sum; 
    }

    static void print(Stack<int> stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }

    static void fillStack(Stack<int> stack)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            stack.Push(numbers[i]);
        }
    }
}
