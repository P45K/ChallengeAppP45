namespace ChallengeAppP45
{
    // Klasa (1)
    public class Employee
    {
        // Lista 
        private List<float> grades = new List<float>();

        // Konstruktor (3)
        public Employee(string firstName, string lastName, int yearOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.YearOfBirth = yearOfBirth;
        }

        // Właściwości (2)
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int YearOfBirth { get; private set; }

        // Metody (4)
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else if (grade < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR! Value must be positive (min 0, max 100)!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR! Value has ben exceeded (min 0, max 100)!");
                Console.ResetColor();
            }
        }

        public void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            this.AddGrade(gradeInInt);
            //Console.WriteLine(gradeInInt);
        }

        public void AddGrade(long grade) // druga metoda o tej samej nazwie "AddGrade" ale z innym parametrem
        {
            float gradeInLong = (float)grade;
            this.AddGrade(gradeInLong);
            //Console.WriteLine(gradeInLong);
        }

        public void AddGrade(double grade)
        {
            float gradeInDouble = (float)Math.Ceiling(grade); // "Math.Ceiling" zaokrąglanie w górę
            this.AddGrade(gradeInDouble);
            //Console.WriteLine(gradeInDouble);
        }

        public void AddGrade(decimal grade)
        {
            float gradeInDecimal = (float)grade;
            this.AddGrade(gradeInDecimal);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR! Value must be a number (min 0, max 100)!");
                Console.ResetColor();
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count) ; // pętla "while" - poętla może się nie wykonać
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}