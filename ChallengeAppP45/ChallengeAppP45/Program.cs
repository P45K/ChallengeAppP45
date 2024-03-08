User user1 = new User("Przemek", "12345");
User user2 = new User("Gabriel", "54321");
User user3 = new User("Julia", "67890");
User user4 = new User("Wioleta", "09876");

user1.AddScore(5);

class User
{
    private int score;

    //  KONSTRUKTOR
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.score = 0;
    }

    //  POLA - parametry opisuące nasz obiekt
    public string Login { get; private set; }     // propercja (property) - właściwości klasy, gdzie (get) zwraca wartość, a (set) ustawia wartość, w tym przypadku set jest dostępne tylko wewnatrz klasy 
    public string Password { get; private set; }

    //  METODA 

    public void AddScore(int number) 
    {
        this.score += number;
    }
}