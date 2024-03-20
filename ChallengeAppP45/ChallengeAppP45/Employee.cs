namespace ChallengeAppP45
{
    //(1)// KLASA
    public class Employee
    {
        //(4)// LISTA
        private List<float> grades = new List<float>();

        //(3)// KONSTRUKTOR
        // KONSTRUKTOR - jest metodą specjalna w klasie, celem
        public Employee(string firstName, string lastName, int yearOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.YearOfBirth = yearOfBirth;
        }

        //(2)// POLA
        // POLA - czyli zmienne składowe klasy
        public string FirstName { get; private set; } // propercje (właściwości) - mechanizm umożliwiający kontrolowany dostęp do pól klasy poprzez specjalne metody, które są nazywane getterami i setterami.
        public string LastName { get; private set; }
        public int YearOfBirth { get; private set; }

        //(5)// METODY

        public void AddGrade(float grade)
        {
            // int ValueinInt = (int)grade; // rzutowanie (konwersja z float na int)

            //int ValueinInt = (int)Math.Ceiling(grade); // zaokrągla w górę, np "double grade = 3.3", to wynik będzie 4
            // int ValueInInt = (int)Math.Floor(grade); // zaokrągla w dół, np " double grade = 3.3", to wynik będzie 3

            // float f = (float)ValueinInt; // w przypadku rzutowania z int do float nie tracimy danych, można zapisać również "float f = ValueInInt;"

            if (grade >= 0 && grade <= 99.999f)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value!");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics(); // tworzenie zmiennej, nowej instancji obiektu klasy "Statistics"
            statistics.Average = 0; // inicjalizacja pola "Average" z domyślną wartością "0"
            statistics.Max = float.MinValue; // inicjalizacja pola "Max" z wartością "float.MinValue" - najniższa możliwa wartość float (-3.40282347 × 10^38)
            statistics.Min = float.MaxValue; // inicjalizacja pola "Min" z wartością "float.MaxValue" - najwyższa możliwa wartość float (3.40282347 × 10^38)

            foreach (var grade in this.grades) // pętla "foreach"  ma za zadanie wyłapać najwyższą i najniższą wartość, oraz średnią ocen, "this" odwołuje się do obiektu, w którym jesteśmy 
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