

var greenLight = int.Parse(Console.ReadLine());
var freeWindow = int.Parse(Console.ReadLine());

var cars = new Queue<string>();
var totalCarPassed = 0;
var isHitted = false;
while (true)
{
    var input = Console.ReadLine();
    if (input == "END") { 
        break;
    }
    else if (input != "green")
    {
        cars.Enqueue(input);
        continue;
    }
    else if(input == "green")
    {
        var currentLight = greenLight;

        while (cars.Count > 0)
        {
            var currCar = cars.Dequeue();
            if(currCar.Length <= currentLight)
            {
                totalCarPassed++;
                currentLight -= currCar.Length;
                continue;
            }
            else if(currCar.Length + currentLight <= freeWindow)
            {
                totalCarPassed++;
                currentLight = 0;
                break;
            }
            else {
                var hiitedChar = currCar[currentLight + freeWindow];
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{currCar} was hit at {hiitedChar}.");
                isHitted = true;
                Console.ReadKey();
                break;
            }

        }
        
    }
    if (isHitted)
        break;

}


if (!isHitted)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{totalCarPassed} total cars passed the crossroads.");
}

Console.ReadKey();
