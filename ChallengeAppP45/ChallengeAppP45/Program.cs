using ChallengeAppP45;

Console.WriteLine();
Console.WriteLine(" SECTION 9 - Employee Evaluation Program");
Console.WriteLine(" ---------------------------------------");
Console.WriteLine();

var employee = new Employee("Motoko", "Kusanagi", 1995);

while (true)
{
    Console.Write($" Assign additional points to the employee: {employee.FirstName} {employee.LastName}: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStats();
Console.WriteLine();
Console.WriteLine(" ---------------------------------");
Console.WriteLine($" Statistics for: {employee.FirstName} {employee.LastName}");
Console.WriteLine(" ---------------------------------");
Console.WriteLine($" Average employee rating: [ {statistics.Average:N2} ]   Employee class: [ {statistics.AverageLetter} ]");
Console.WriteLine($" Highest rating: [ {statistics.Max} ]   Lowest rating: [ {statistics.Min} ]");