
var studentsCount = int.Parse(Console.ReadLine());

var studentsByGrade = new Dictionary<string, List<decimal>>();

for (int i = 0; i < studentsCount; i++)
{
    var tokens = Console.ReadLine().Split();
    var studentName = tokens[0];
    var grade = decimal.Parse(tokens[1]);

    if (!studentsByGrade.ContainsKey(studentName))
    {
        studentsByGrade.Add(studentName, new List<decimal>());
    }
    studentsByGrade[studentName].Add(grade);
}

foreach (var (student,grades) in studentsByGrade)
{
    var gradeStr = string.Join(" ", grades.Select(g => g.ToString("f2")));

    Console.WriteLine($"{student} -> {gradeStr} (avg: {grades.Average():f2})");
}
Console.ReadKey();