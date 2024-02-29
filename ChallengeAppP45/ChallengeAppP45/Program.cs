// Dzień 4 - Zadanie Domowe
var varName = "Gabriel";
var varSex = 'M'; // M = male, F = female
var varAge = 8;

if (varSex == 'F' && varAge < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (varName == "Ewa" && varAge == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (varSex == 'M' && varAge < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    // pusty blok else - nie zostały spełnione żadne warunki, dlatego program nie zwrócił komunikatu
}