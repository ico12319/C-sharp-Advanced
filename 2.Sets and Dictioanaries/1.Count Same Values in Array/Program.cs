
var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
var numbersByCount = new Dictionary<double, int>();

for (int i = 0; i < numbers.Length; i++)
{
    if (!numbersByCount.ContainsKey(numbers[i]))
    {
        numbersByCount.Add(numbers[i], 0);
    }
    numbersByCount[numbers[i]]++;
}

foreach (var item in numbersByCount)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}

Console.ReadKey();