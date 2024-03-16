using ChallengeAppP45;

var employee = new Employee("Motoko", "Kusanagi", 1995); // tworzymy pracownika
employee.Addgrade(6); // przyznajemy punkty pracownikowi
employee.Addgrade(7);
employee.Addgrade(7);
employee.Addgrade(7);
employee.Addgrade(8);
employee.Addgrade(8);
employee.Addgrade(9);
employee.Addgrade(9);
employee.Addgrade(10);
employee.Addgrade(10);
var statistics = employee.GetStatistics();

//  GUI I BAJERY
Console.SetWindowSize(83, 20); // ustawiamy szerokość okna na 83 i wysokość na 20
Console.BackgroundColor = ConsoleColor.DarkGreen; // zmiana koloru tła konsoli

Console.WriteLine();
Console.WriteLine(" S Y S T E M   I N I T I A L I Z I N G");
for (int i = 0; i < 19; i++)
{
    Console.Write(" »");
    Thread.Sleep(50); // opóźnienie między każdym znakiem
}
Thread.Sleep(1500); // 1,5 sec pauzy do wykonania kolejnego wiersza kodu

Console.Clear();
Console.WriteLine();
Console.WriteLine("  ┌─────────────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("  │  by SR45           < SECTION 9 - EMPLOYE GRADE SYSTEM >       version a.01  │");
Console.WriteLine("  └─────────────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

int durationMilliseconds = 3000;
int updateInterval = 100;
for (int i = 0; i <= durationMilliseconds; i += updateInterval) // symulująca ładowanie treści (kolejny bajer)
{
    Console.Write($"\r   Employee Searching {(i % 200 < 100 ? "/" : "\\")}");
    Thread.Sleep(updateInterval);
}

Thread.Sleep(1000);
Console.Write("\r   Employee found in database:  ");
Thread.Sleep(3000);

foreach (char c in employee.GetEmployeeInfo())
{
    Console.Write(c);
    Thread.Sleep(80);
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i <= durationMilliseconds; i += updateInterval) // tu znowu symulacja przeszukiwania bazy danych ;)
{
    Console.Write($"\r   Grades searching {(i % 200 < 100 ? "/" : "\\")}");
    Thread.Sleep(updateInterval);
}

Console.Write("\r   Grades found in database: ");
Thread.Sleep(3000);
Console.Write($" MIN: {statistics.Min}  ");
Thread.Sleep(500);
Console.Write($"MAX: {statistics.Max}  ");
Thread.Sleep(1000);
Console.WriteLine($"AVERAGE: {statistics.Average:N2} ");
Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("   Press ESC to close the console, or wait 20 seconds.");

// to coś poniżej sprawdza, czy został naciśnięty klawisz ESC - to nie ja pisałem, to pisało SI :)
var escThread = new Thread(() =>
{
    while (true)
    {
        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
        Thread.Sleep(100); // opóźnienie między sprawdzaniem klawiszy (100 ms)
    }
});
escThread.Start();
Console.WriteLine();

for (int i = 0; i < 20; i++) // kropka co sekundę przez 20 sekund
{
    Thread.Sleep(1000);
    Console.Write("   .");
}
Environment.Exit(0);