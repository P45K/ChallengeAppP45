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
// W c# domyślnie zmienne są przekazywane przez wartości, co oznacza, że do metody przekazywana jest kopia wartości danej zmiennej.

/*  
    void SetStat(Statistics statistics) // typ referencyjny i przekazanie wartości(kopię wartości) przez referencję
    {
        statistics = new Statistics();
    }

    public void Addgrade(float grade) // typ wartościowy i przekazanie wartości (kopii wartości)
    {
        this.grades.Add(grade);
    } 
*/

// W niektórych przypadkach możemy chcieć przekazać referencję do oryginału zmiennej, a nie kopię, w takich sytuacjach korzystamy ze słowa kluczowego "ref" i "out"

// Przekazywanie przez referencję za pomocą ref oznacza, że oryginalna zmienna zostanie przekazana do metody jako referencja, co umożliwia zarówno odczyt, jak i zapis do tej zmiennej wewnątrz metody

/*
void SetStat(ref Statistics statistics) // Przekazywanie przez referencję za pomocą "ref"
{
    statistics = new Statistics();
}
*/

// Przekazywanie przez referencję za pomocą out jest podobne do ref, ale służy głównie do zwracania wielu wartości z metody. Wartość zmiennej out musi być zainicjowana wewnątrz metody, przed jej użyciem.

/*
void SetStat(out Statistics statistics) // Przekazywanie przez referencję za pomocą "out"
{
    statistics = new Statistics();
}
*/