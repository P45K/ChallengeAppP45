using ChallengeAppP45;

var employee = new Employee("Motoko", "Kusanagi", 1995);
employee.AddGrade(2.22f);
employee.AddGrade(0.01);
employee.AddGrade('C');
employee.AddGrade("10");
employee.AddGrade('F');
employee.AddGrade(-20);
employee.AddGrade("lipa");

Console.WriteLine();
var statistics = employee.GetStats();
Console.WriteLine(statistics.AverageLetter);