using ChallengeAppP45;

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika: ");
var input = Console.ReadLine();

var employee = new Employee("Motoko", "Kusanagi", 1995);
employee.AddGrade(input);
var statistics = employee.GetStats();
Console.Write($"Średnia ocena pracownika: [ {statistics.Average} ]   Klasa pracownika: [ {statistics.AverageLetter} ]");