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
            var statistics = new Statistics();



            return statistics;
        }
    }
}