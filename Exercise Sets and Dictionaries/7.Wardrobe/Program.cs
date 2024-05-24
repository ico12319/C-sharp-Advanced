


var contestPasswords = new Dictionary<string, string>();

fillContestPasswords(contestPasswords);
var usersContests = new SortedDictionary<string, Dictionary<string,int>>();

fillContestsParticipants(usersContests, contestPasswords);

var max = 0;
var winner = findWinner(usersContests,ref max);

Console.WriteLine($"Best candidate is {winner} with total {max} points.");
Console.WriteLine("Ranking:");
foreach (var item in usersContests)
{
    Console.WriteLine($"{item.Key}");
    var sorted = item.Value.OrderByDescending(v => v.Value).ToDictionary(key =>key.Key,value => value.Value);
    foreach (var contest in sorted)
    {
        Console.WriteLine($"# {contest.Key} -> {contest.Value}");
    }
}
Console.ReadKey();





static void fillContestPasswords(Dictionary<string,string> dictionary)
{
    while (true)
    {
        var input = Console.ReadLine();
        if (!input.Contains("end"))
        {
            var tokens = input.Split(":");
            var contest = tokens[0];
            var password = tokens[1];

            if (!dictionary.ContainsKey(contest))
                dictionary.Add(contest, password);
        }
        else
        {
            break;
        }
    }
}

static string findWinner(SortedDictionary<string, Dictionary<string, int>> dic,ref int max)
{
    var winner = string.Empty;
    var sum = 0;

    foreach (var item in dic)
    {
        foreach (var item1 in item.Value)
        {
            sum += item1.Value;
        }
        if (sum > max)
        {
            max = sum;
            winner = item.Key;
        }
        sum = 0;

    }
    return winner;
}


static void fillContestsParticipants(SortedDictionary<string, Dictionary<string, int>> usersContests,Dictionary<string,string> contestPasswords)
{
    while (true)
    {
        var input = Console.ReadLine();
        if (!input.Contains("end"))
        {
            var tokens = input.Split("=>");
            var contest = tokens[0];
            var password = tokens[1];
            var name = tokens[2];
            var points = int.Parse(tokens[3]);

            if (!usersContests.ContainsKey(name) && contestPasswords.ContainsKey(contest) && contestPasswords[contest] == password)
                usersContests.Add(name, new Dictionary<string, int>());

            else if (!contestPasswords.ContainsKey(contest))
                continue;
            else if (contestPasswords.ContainsKey(contest) && contestPasswords[contest] != password)
                continue;

            if (!usersContests[name].ContainsKey(contest))
                usersContests[name].Add(contest, points);

            else if (usersContests[name].ContainsKey(contest) && points > usersContests[name][contest])
                usersContests[name][contest] = points;

        }

        else
            break;

    }
}