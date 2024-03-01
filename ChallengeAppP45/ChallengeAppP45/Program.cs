// DZIEŃ 5 - POŁĄCZENIE TABLIC I PĘTLI FOR

int[] grades = new int[5];
string[] dayOfWeeks = new string[7]; 
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";

for(var i=0; i<dayOfWeeks.Length; i=i+2) // gdzie: "i<dayOfWeeks.Length;" zwraca długości (ilość elementów) tablicy "dayOfWeeks" z 4 lini kodu / "i=i+2" zwiększa wartość "i" o dwa
{
    Console.WriteLine(dayOfWeeks[i]);
}