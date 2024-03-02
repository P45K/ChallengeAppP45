User user1 = new User();
User user2 = new User();
User user3 = new User();
User user4 = new User();

user1.login = "Przemek";        // przypisanie wartości do pól "login" i "password"
user1.password = "password";

class User
{
    public string login;        // publiczne pole w klasie typu (string) o nazwie "login"  - to zmienna, która jest dostępna i można ją modyfikować
    public string password;
    private string name;        // prywatne pole w klasie typu (string) o nazwie "name"  - to zmienna, która jest widoczna tylko wewnątrz klasy dla której została zadeklarowana, dzieki temu nie ma do niej dostępu i nie można jej modyfikować z zewnątrz
}