
var carNumbers = new HashSet<string>();

while (true)
{
    var tokens = Console.ReadLine().Split(", ");
    var direction = tokens[0];

    if (direction == "END")
        break;

    var number = tokens[1];
    if (direction == "IN")
    {
        carNumbers.Add(number);
    }
    else if(direction == "OUT" && carNumbers.Contains(number))
    {
        carNumbers.Remove(number);
    }
}
if(carNumbers.Count == 0)
    Console.WriteLine("Parking lot is Empty");

Console.WriteLine(string.Join(Environment.NewLine,carNumbers));
Console.ReadKey();