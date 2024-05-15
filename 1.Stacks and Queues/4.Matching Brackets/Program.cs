using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        extractSubExpr(input);
        Console.ReadKey();
    }


    static void extractSubExpr(string input)
    {
        var stack = new Stack<int>();
        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                stack.Push(i);
            }
            else if (input[i] == ')')
            {
                var startIndex = stack.Pop();
                var endIndex = i;

                var exr = input.Substring(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(exr);
            }
        }
    }
    

}