using ChallengeAppP45;

var employee = new Employee("Motoko", "Kusanagi", 1995);
employee.AddGrade(2.22f);
employee.AddGrade(0.01);
employee.AddGrade(5);
employee.AddGrade(20);
employee.AddGrade("6");
employee.AddGrade("lipa");
employee.AddGrade(99.999d);
employee.AddGrade(9999999999999999);
employee.AddGrade(-9);
employee.AddGrade('F');

Console.WriteLine();

// Wyświetlanie - staty dla "foreach"
var statsForEach = employee.GetStatsForEach();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("<< EMPLOYEE STATS - FOREACH >>");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}  =>  [ Max: {statsForEach.Max} ]   [ Min: {statsForEach.Min} ]   [ Average: {statsForEach.Average:N2} ]");
Console.ResetColor();