using ChallengeAppP45;

Employee employee1 = new Employee("Edek", "Zkrainykredek", "22");   // "Employee" jest typem obiektu "employee1"
Employee employee2 = new Employee("Janek", "Rambo", "55");
Employee employee3 = new Employee("Franek", "Mistrzkarate", "44");
Employee employee4 = new Employee("Bob", "Mistrzreggae", "37");
Employee employee5 = new Employee("Zenek", "Rezyserkinaakcji", "33");

List<Employee> allEmployees = new List<Employee>() 
{ 
    employee1, employee2, employee3, employee4, employee5 
};

employee1.AddPoints(6);
employee1.AddPoints(8);
employee1.AddPoints(7);
employee1.AddPoints(9);
employee1.AddPoints(5);

employee2.AddPoints(8);
employee2.AddPoints(9);
employee2.AddPoints(7);
employee2.AddPoints(10);
employee2.AddPoints(7);

employee3.AddPoints(7);
employee3.AddPoints(8);
employee3.AddPoints(9);
employee3.AddPoints(4);
employee3.AddPoints(8);

employee4.AddPoints(7);
employee4.AddPoints(7);
employee4.AddPoints(10);
employee4.AddPoints(8);
employee4.AddPoints(9);

employee5.AddPoints(7);
employee5.AddPoints(4);
employee5.AddPoints(9);
employee5.AddPoints(10);
employee5.AddPoints(8);

int bestScore = 0;

List<Employee> topEmployees = new List<Employee>();

foreach (var bestEmployee in allEmployees)    // pętla przechodzi przez wszystkich pracowników z listy "allEmployees", szuka najwyższego wyniku "bestScore" i dodaje go do listy "topEmployees"
{
    if (bestEmployee.Result == bestScore)
    {
        topEmployees.Add(bestEmployee);
    }
    else if (bestEmployee.Result > bestScore) // kiedy kolejny wynik jest większy od aktualnego, lista "topEmployee" zostaje wyczyszczona, następnie zaktualizowana
    {
        bestScore = bestEmployee.Result;
        topEmployees.Clear();
        topEmployees.Add(bestEmployee);
    }
}

Console.WriteLine("-------------------------------");
Console.WriteLine("     B E S T    S C O R E:");
Console.WriteLine("-------------------------------");
foreach (var winnerEmployee in topEmployees)    // pętla ma za zadanie wyświetlić najlepsze wyniki z listy "topEmployees"
{
    Console.WriteLine(winnerEmployee.Name + " " + winnerEmployee.SurName + " - " + winnerEmployee.Result + "pkt");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-------------------------------");
Console.WriteLine("     A L L    S C O R E S:");
Console.WriteLine("-------------------------------");

foreach (var restEmployees in allEmployees.OrderByDescending(x => x.Result))    // tutaj pętla sortuje wszystkie wyniki od największej do najmniejszej liczby pkt
{
    Console.WriteLine(restEmployees.Name + " " + restEmployees.SurName + " - " + restEmployees.Result + "pkt");
}