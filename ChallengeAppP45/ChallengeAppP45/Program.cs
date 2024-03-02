User user1 = new User("Przemek");
User user2 = new User("Gabriel");
User user3 = new User("Julia");
User user4 = new User("Wioleta");



class User
{
    private string login;
    private string password;
    private string name;

    public User(string login)               // tworzenie konstruktowa dla klasy "User", z parametrem "login", który jest typu (string)
    {
        this.login = login;
    }
}