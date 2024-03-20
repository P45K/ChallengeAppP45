using ChallengeAppP45;

var employee = new Employee("Motoko", "Kusanagi", 1995); // tworzymy pracownika
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade("6");

var statistics = employee.GetStatistics();

Console.WriteLine("Employee Statistics:");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} => Max:{statistics.Max} Min:{statistics.Min} Average:{statistics.Average:N2}");