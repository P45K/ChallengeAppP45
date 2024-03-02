User user1 = new User();    // wywołanie "user1" bez parametrów
User user2 = new User("Gabriel", "");   // wywołanie "user2" z dwoma parametrami
User user3 = new User("Julia");     // wywołanie "user2" z jednym parametrem 
User user4 = new User("Wioleta");

class User
{
    private string login;
    private string password;
    private string name;

    public User()   // konstruktor bez parametrów 
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }

    public User(string login)   // konstruktor z jednym parametrem
    {
        this.login = login;
        this.password = "-";
        this.name = "-";
    }

    public User(string login, string password)  // konstruktor z dwoma parametrami
    {
        this.login = login;
        this.password = password;
        this.name = "-";
    }
}