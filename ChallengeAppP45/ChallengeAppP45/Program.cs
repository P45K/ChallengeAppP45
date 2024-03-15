using ChallengeAppP45;

var employee = new Employee("Edziu", "Pierwszy");
employee.Addgrade(5);
employee.Addgrade(5);
employee.Addgrade(5);
employee.Addgrade(4);
employee.Addgrade(4);
employee.Addgrade(3);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}"); // ($"łańcuchtxt {wyrażenie}") - interpolacja stringów - pozwala wstawiać wartości zmiennych bezpośrednio do łańcuchów tekstowych (stringów), "N2" - to formatowanie liczby zmiennoprzecinkowej, w tym przypadku liczba ma być sformatowana do 2 miejsc po przecinku
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
