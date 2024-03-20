using ChallengeAppP45;

var employee = new Employee("Motoko", "Kusanagi", 1995); // tworzymy pracownika
employee.AddGrade(2.22f);
employee.AddGrade(5);
employee.AddGrade(200);
employee.AddGrade("6");
employee.AddGrade("lipa");
employee.AddGrade(99.9923455d);
employee.AddGrade(99999999998);

var statistics = employee.GetStatistics();

Console.WriteLine("Employee Statistics:");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} => Max:{statistics.Max} Min:{statistics.Min} Average:{statistics.Average:N2}");