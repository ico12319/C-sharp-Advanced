
var symbolsByCount = new SortedDictionary<char, int>();

var input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    if (!symbolsByCount.ContainsKey(input[i]))
    {
        symbolsByCount.Add(input[i], 0);
    }
    symbolsByCount[input[i]]++;
}

foreach (var symbol in symbolsByCount)
{
    Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
}
Console.ReadKey();