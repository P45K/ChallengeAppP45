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

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine("<< Employee Statistics >>");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} => Max:{statistics.Max} Min:{statistics.Min} Average:{statistics.Average:N2}");