

var numbersByCount = new Dictionary<int,int>();

var numbersCount = int.Parse(Console.ReadLine());

for (int i = 0; i < numbersCount; i++)
{
    var num = int.Parse(Console.ReadLine());
    if (!numbersByCount.ContainsKey(num))
    {
        numbersByCount.Add(num, 0);
    }
    numbersByCount[num]++;
}

var filteredItem = numbersByCount.Where(values => values.Value % 2 == 0).Take(1);

foreach (var item in filteredItem)
{
    Console.WriteLine(item.Key);
}
Console.ReadKey();