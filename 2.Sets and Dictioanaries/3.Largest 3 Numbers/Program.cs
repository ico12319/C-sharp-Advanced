

var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

numbers = numbers.OrderByDescending(n => n).Take(3).ToArray();

Console.WriteLine(string.Join(" ",numbers));
Console.ReadKey();