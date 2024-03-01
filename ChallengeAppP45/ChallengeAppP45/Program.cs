// DZIEŃ 5 - PĘTLA FOREACH

int[] grades = new int[5];

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
dayOfWeeks.Add("i po niedzieli");

foreach (var day in dayOfWeeks) // tworzenie pętli "foreach" / zmienna "day" po każdym przejściu pętli, przejmie wartość kolejnego elementu z listy "dayOfWeeks".
{
    Console.WriteLine(day);
}