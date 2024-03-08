namespace ChallengeAppP45   // przestrzeń nazw
{
    public class User
    {
        // public static string GameName = "Diablo";   // zmienna statyczna 

        private List<int> score = new List<int>();

        //  KONSTRUKTOR
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        //  POLA - parametry opisuące nasz obiekt
        public string Login { get; private set; }   // propercja (property) - właściwości klasy, gdzie (get) zwraca wartość, a (set) ustawia wartość, w tym przypadku set jest dostępne tylko wewnatrz klasy 
        public string Password { get; private set; }

        public int Result
        {
            get     // 
            {
                return this.score.Sum();    // metoda "Sum" sumuje wszystkie punkty(liczby) na liście
            }
        }

        //  METODA
        public void AddScore(int number)    // metoda "AddScore" dodaje kolejne liczby do listy "score" 
        {
            this.score.Add(number);
        }
    }
}
