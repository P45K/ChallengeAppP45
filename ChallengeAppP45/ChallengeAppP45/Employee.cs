namespace ChallengeAppP45
{
    // KLASA
    public class Employee
    {
        private List<int> score = new List<int>();

        // KONSTRUKTOR
        public Employee(string name, string surName, string age)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
        }

        // POLA
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        // METODA

        public void AddPoints(int points)
        {
            this.score.Add(points);
        }
    }
}