// DZIEŃ 5 - PĘTLA FOR

int[] grades = new int[5]; // (eng)grades -> (pl)oceny / var grades = new int[5]; - też dobrze
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";

for(var i=0; i<=45; i++)  // gdzie: var i=0; to inicjalizacja zmiennej typu "int" / i<=45; to warunek który musi zostać spełniony, aby pętla kontynuowała swoje działanie / i++ (inkrementacja) to instrukcja wykonana po każdym przebiegu pętli (zwiększa wartość "i" o jeden)  
{
    Console.WriteLine(i);
}