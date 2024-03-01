// DZIEŃ 5 - LISTY

int[] grades = new int[5];

List<string> dayOfWeeks = new List<string>(7); // tworzenie listy o parametrze generycznym "<string>"(określa jakiego typu danych jest lista), nie trzeba określać wielkości listy "()", zwiększa się dynamicznie poprzez dodanie kolejnej funkcji "Add"
dayOfWeeks.Add("poniedziałek"); // funkcja "Add" dodaje nowy element (wartość) do listy, operacja pozwalająca o rozszerzanie listy o nowe dane.
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
dayOfWeeks.Add("i po niedzieli");

for(var i=0; i<dayOfWeeks.Count; i++) // gdzie "dayOfWeeks.Count" powoduje, że pętla wykona sie określoną ilość razy, ilośc razy określa wielkość listy.
{
    Console.WriteLine(dayOfWeeks[i]);
}