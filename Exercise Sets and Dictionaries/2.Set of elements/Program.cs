

var sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

var set1Size = sizes[0];
var set2Size = sizes[1];
var set1 = new HashSet<int>();
var set2 = new HashSet<int>();

fillSets(set1, set1Size, set2Size, set2);

var set3 = set1.Intersect(set2);

Console.WriteLine(string.Join(" ",set3));
Console.ReadKey();









static void fillSets(HashSet<int> set1,int size1,int size2,HashSet<int> set2)
{
    int count = 0;
    for (int i = 0; i < size1 + size2; i++)
    {
        var numbers = Console.ReadLine();
        if (count < size1)
        {
            set1.Add(int.Parse(numbers));
            count++;

        }
        else
        {
            set2.Add(int.Parse(numbers));
        }

    }
}