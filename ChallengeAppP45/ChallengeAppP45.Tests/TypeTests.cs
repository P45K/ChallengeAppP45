namespace ChallengeAppP45.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // arrange
            var user1 = GetUser("Edziu");       // gdzie "user1" i user2" to typ referencjyjny, zajmują różne miejsce w pamięci(są różne)
            var user2 = GetUser("Edziu");       // gdzie "Edziu" i "Władziu" to typ wartościowy
            var user3 = GetUser("Władziu");

            // act


            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }

        private User GetUser(string name) 
        {
            return new User(name);
        }
    }
}
