using ChallengeAppP45;

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();

// var employee = new Employee("Motoko", "Kusanagi", 1995);
var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStats();
Console.WriteLine();
Console.WriteLine($"Średnia ocena pracownika: [ {statistics.Average} ]   Klasa pracownika: [ {statistics.AverageLetter} ]");
Console.WriteLine($"Ocena najwyższa: [ {statistics.Max} ]   Ocena najniższa: [ {statistics.Min} ]");