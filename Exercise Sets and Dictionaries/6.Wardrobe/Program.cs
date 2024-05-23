


var clothesCount = int.Parse(Console.ReadLine());

var wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < clothesCount; i++)
{
    var input = Console.ReadLine();
    if (input.Contains("->"))
    {
        var parts = input.Split(" -> ");
        var color = parts[0];
        var clothes = parts[1].Split(",");

        for (int j = 0; j < clothes.Length; j++)
        {
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }
            if (!wardrobe[color].ContainsKey(clothes[j]))
            {
                wardrobe[color].Add(clothes[j], 0);
            }
            wardrobe[color][clothes[j]]++;
        }

        
    }
}

var endInput = Console.ReadLine().Split();
var colorEnd = endInput[0];
var clothEnd = endInput[1];

foreach (var item in wardrobe)
{
    Console.WriteLine($"{item.Key} clothes:");
    foreach (var clothe in item.Value)
    {
        if (colorEnd == item.Key && clothEnd == clothe.Key)
        {
            Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"{clothe.Key} - {clothe.Value}");
        }
    }
}
Console.ReadKey();