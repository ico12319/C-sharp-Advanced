
var guests = new HashSet<string>();

var isStopped = false;
while (true)
{
    var reservationNumber = Console.ReadLine();

    if(reservationNumber != "PARTY")
    {
        guests.Add(reservationNumber);
    }
    else
    {
        while (true)
        {
            var newNums = Console.ReadLine();
            if (newNums == "END")
            {
                isStopped = true;
                break;
            }
            else
            {
                guests.Remove(newNums);
            }
        }
    }
    if (isStopped)
        break;
}

Console.WriteLine(guests.Count);
guests = guests.OrderByDescending(isVipGuest).ToHashSet();
Console.WriteLine(string.Join(Environment.NewLine,guests));
Console.ReadKey();



static bool isDigit(char s)
{
    return s >= '0' && s <= '9';
}

static bool isVipGuest(string number)
{
    return isDigit(number[0]);
}