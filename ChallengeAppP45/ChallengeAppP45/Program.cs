using ChallengeAppP45;

var employee = new Employee("Motoko", "Kusanagi", 1995); // tworzymy pracownika
employee.Addgrade(6); // przyznajemy punkty pracownikowi
employee.Addgrade(7);
employee.Addgrade(7);
employee.Addgrade(7);
employee.Addgrade(8);
employee.Addgrade(101);
employee.Addgrade(9);
employee.Addgrade(9);
employee.Addgrade(10);
employee.Addgrade(10);
var statistics = employee.GetStatistics();

Console.WriteLine("Employee Statistics:");
Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} => Max:{statistics.Max} Min:{statistics.Min} Average:{statistics.Average:N2}");