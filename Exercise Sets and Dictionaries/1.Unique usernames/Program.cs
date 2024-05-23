

var usernameCount = int.Parse(Console.ReadLine());
var set = new HashSet<string>();


for (int i = 0; i < usernameCount; i++)
{
    var name = Console.ReadLine();
    set.Add(name);
}


foreach (var item in set)
{
    Console.WriteLine(item);
}
Console.ReadKey();