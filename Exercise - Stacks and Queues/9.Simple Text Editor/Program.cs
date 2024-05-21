

using System.Text;

var text = new StringBuilder();
var history = new Stack<string>();

var operationsCount = int.Parse(Console.ReadLine());

while (operationsCount!=0)
{
    var tokens = Console.ReadLine().Split();

    var first = tokens[0];

    if (first == "1")
    {
        history.Push(text.ToString());
        var textToAdd = tokens[1];
        text.Append(textToAdd);
    }
    else if(first == "2")
    {
        history.Push(text.ToString());
        var elToRemove = int.Parse(tokens[1]);
        text.Remove(text.Length - elToRemove, elToRemove);
    }
    else if(first == "3")
    {
        var index = int.Parse(tokens[1]);
        Console.WriteLine(text[index - 1]);
    }
    else if(first == "4")
    {
        if(history.Count > 0)
        {
            text.Clear();
            text.Append(history.Pop());
        }
    }
    operationsCount--;
}
Console.ReadKey();