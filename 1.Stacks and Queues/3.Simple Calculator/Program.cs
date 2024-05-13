using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<string>();
        var input = Console.ReadLine().Split().ToList();
        input.Reverse();

        fillStack(stack, input);
        printStack(stack);

        Console.WriteLine(manipulateStack(stack));
        Console.ReadKey();
    }

    static void fillStack(Stack<string> stack, List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            stack.Push(list[i].ToString());
        }
    }

    static void printStack(Stack<string> stack)
    {
        Console.WriteLine(string.Join(" ", stack));
    }

    static int manipulateStack(Stack<string> stack)
    {
        var res = int.Parse(stack.Pop());

        while (stack.Count > 0)
        {
            var sign = stack.Pop();
            var number = int.Parse(stack.Pop());

            if (sign == "+")
            {
                res += number;
            }
            else
            {
                res -= number;
            }
        }

        return res;
    }

}