

var elementsCount = int.Parse(Console.ReadLine());
var table = new HashSet<string>();

for (int i = 0; i < elementsCount; i++)
{
    var elements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0;  j < elements.Length;  j++)
    {
        table.Add(elements[j]);
    }
}
table = table.OrderBy(n => n).ToHashSet();
Console.WriteLine(string.Join(" ",table));
Console.ReadKey();