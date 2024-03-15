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


// Parametry wartościowe i referencyjne w metodach są przekazywane zawsze przez wartość: dla typów wartościowych przez wartośc typu wartościowego, a dla typów referencyjnych przez wartość referencji

/*  SetStat(Statistics statistics) // typ referencyjny i przekazanie wartości przez referencję
    {
        statistics = new Statistics();
    }

    public void Addgrade(float grade) // typ wartościowy i przekazanie wartości
    {
        this.grades.Add(grade);
    } */