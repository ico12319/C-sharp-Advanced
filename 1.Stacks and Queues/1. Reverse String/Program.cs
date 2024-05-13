using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var reversed = ReverseString(input);

        Console.WriteLine(reversed);
        Console.ReadKey();
    }


    static string ReverseString(string input)
    {
        var stack = new Stack<char>();

       for(int i = 0; i < input.Length; i++)
       {
            stack.Push(input[i]);
       }

        var res = string.Empty;
        foreach (var item in stack)
        {
            res += item;
        }

        return res;
    }

}
