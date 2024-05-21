var priceBull = int.Parse(Console.ReadLine());
var gunSize = int.Parse(Console.ReadLine());

var bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

var locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

var valueIntell = int.Parse(Console.ReadLine());


var bullets = new Stack<int>(bulletsInput);
var locks = new Queue<int>(locksInput);
var shoots = 0;
var originalBulletsCount = bullets.Count;
var success = false;
while (true)
{
    if (bullets.Count > 0)
    {
        if (locks.Count > 0)
        {
            var currBullet = bullets.Pop();
            
            var currLocks = locks.Peek();
           
            
            if (currBullet <= currLocks)
            {
                Console.WriteLine("Bang!");
                locks.Dequeue();
                shoots++;
                if (shoots == gunSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    shoots = 0;
                }
            }
            else
            {
                Console.WriteLine("Ping!");
                shoots++;
                if (shoots == gunSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading");
                    shoots = 0;
                }
            }
        }
    }
    else if(locks.Count == 0 && bullets.Count >= 0)
    {
        var money = (originalBulletsCount - bullets.Count) * priceBull;
        Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueIntell - money}");
        break;
    }
    else if (locks.Count == 0)
    {
        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        break;
    }



}

Console.ReadKey();