namespace ChallengeAppP45
{
    // KLASA
    public class Employee
    {
        // LISTA
        private List<float> grades = new List<float>();

        // KONSTRUKTOR
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // POLA
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // METODA
        public void Addgrade(float grade) 
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics(); // tworzenie zmiennej, nowej instancji obiektu klasy "Statistics"
            statistics.Average = 0; // inicjalizacja pola "Average" z domyślną wartością "0"
            statistics.Max = float.MinValue; // inicjalizacja pola "Max" z wartością "float.MinValue" - najniższa możliwa wartość float (-3.40282347 × 10^38)
            statistics.Min = float.MaxValue; // inicjalizacja pola "Min" z wartością "float.MaxValue" - najwyższa możliwa wartość float (3.40282347 × 10^38)

            foreach (var grade in this.grades) // pętla "foreach"  ma za zadanie wyłapać najwyższą i najniższą wartość, oraz średnią ocen 
            {
                statistics.Max = Math.Max(statistics.Max, grade); // metoda statyczna z klasy "Math" - pierwsza pobrana wartość z listy "grades" zostanie "Max'em",  następnię każda kolejna wyższa wartość zostanie "Max'em"
                statistics.Min = Math.Min(statistics.Min, grade); // pierwsza pobrana wartośc zostanie przypisana jako minimalna, następnie każda kolejna mniejsza wartość zostanie zapisana jako "Min"
                statistics.Average += grade; // zsumowanie wszystkich ocen
            }
            statistics.Average /= this.grades.Count; // dzielenie przez sume wszystkich ocen (elementów) z listy "grades", dzięki temu otrzymamy średnią 

            return statistics;
        }
    }
}