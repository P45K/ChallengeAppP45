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

Console.WriteLine();

// Wyświetlanie - staty dla "foreach"
var statsForEach = employee.GetStatsForEach();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("<< EMPLOYEE STATS - FOREACH >>");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}  =>  [ Max: {statsForEach.Max} ]   [ Min: {statsForEach.Min} ]   [ Average: {statsForEach.Average:N2} ]");
Console.ResetColor();

Console.WriteLine();

// Wyświetlanie - staty dla "for"
var statsFor = employee.GetStatsFor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("<< EMPLOYEE STATS - FOR >>");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}  =>  [ Max: {statsFor.Max} ]   [ Min: {statsFor.Min} ]   [ Average: {statsFor.Average:N2} ]");
Console.ResetColor();

Console.WriteLine();

// Wyświetlanie - staty dla "while"
var statsWhile = employee.GetStatsWhile();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("<< EMPLOYEE STATS - WHILE >>");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}  =>  [ Max: {statsWhile.Max} ]   [ Min: {statsWhile.Min} ]   [ Average: {statsWhile.Average:N2} ]");
Console.ResetColor();

Console.WriteLine();

// Wyświetlanie - staty dla "do while"
var statsDoWhile = employee.GetStatsDoWhile();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("<< EMPLOYEE STATS - DO WHILE >>");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}  =>  [ Max: {statsDoWhile.Max} ]   [ Min: {statsDoWhile.Min} ]   [ Average: {statsDoWhile.Average:N2} ]");
Console.ResetColor();

Console.WriteLine();