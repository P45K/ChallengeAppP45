using ChallengeAppP45;

User user1 = new User("Przemek", "12345");  // "User" jest typem obiektu "user1"
User user2 = new User("Gabriel", "54321");
User user3 = new User("Julia", "67890");
User user4 = new User("Wioleta", "09876");

user1.AddScore(5);
user1.AddScore(3);
user1.AddScore(7);
var result = user1.Result;
Console.WriteLine(result);
// var name = User.GameName;
