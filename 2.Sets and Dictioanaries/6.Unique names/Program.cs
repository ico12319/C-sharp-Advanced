
var setNames = new HashSet<string>();
var peopleCount = int.Parse(Console.ReadLine());

for (int i = 0; i < peopleCount; i++)
{
    var name = Console.ReadLine();
    setNames.Add(name);
}

foreach (var item in setNames)
{
    Console.WriteLine(item);
}
Console.ReadKey();