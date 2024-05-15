using System;
using System.Collections.Generic;

class Program { 

    static void Main(string[] args)
    {


        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var evenNums = new Queue<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evenNums.Enqueue(nums[i]);
            }
        }

        Console.WriteLine(string.Join(", ",evenNums));
        Console.ReadKey();

    }

    


    

}