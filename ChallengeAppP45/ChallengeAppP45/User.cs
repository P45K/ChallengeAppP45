﻿namespace ChallengeAppP45   // przestrzeń nazw
{
    public class User
    {
        // public static string GameName = "Mucha";   // zmienna statyczna 

        private List<int> score = new List<int>();

        //  KONSTRUKTOR

        public User(int yob)
        {
            this.YearOfBirth = yob;
        }

        public User(string login)
        {
            this.Login = login;
        }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public User(string login, string password, string name)
        {
            this.Login = login;
            this.Password = password;
            this.Name = name;
        }

        public User(string login, string password, string name, int yob)
        {
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.YearOfBirth = yob;
        }

        //  POLA - parametry opisuące nasz obiekt

        public string Login { get; private set; }   // propercja (property) - właściwości klasy, gdzie (get) zwraca wartość, a (set) ustawia wartość, w tym przypadku set jest dostępne tylko wewnątrz klasy 
        public string Password { get; private set; }

        public string Name { get; private set; }

        public int YearOfBirth { get; set; }

        public int Result
        {
            get
            {
                return this.score.Sum();    // metoda "Sum" sumuje wszystkie punkty(liczby) na liście
            }
        }

        //  METODA "+"
        public void AddPositivePoints(int points)    // metoda "AddScore" dodaje punkty dodatnie do listy "score" 
        {
            this.score.Add(points);
        }

        // METODA "-"
        public void AddNegativePoints(int negativePoints)    // metoda "AddNegativeScore" dodaje punkty ujemne do listy "score"
        {
            this.score.Add(negativePoints);
        }
    }
}
