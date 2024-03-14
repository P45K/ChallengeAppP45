namespace ChallengeAppP45.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // arrange
            int number1 = 1;    // int, double, float, byte, long, decimal, short to typy wartościowe
            int number2 = 2;
            string number3 = "3";   // string jest typem referencyjnym, ale zachowuje się jak typ wartościowy

            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange
            var user1 = GetUser("Edziu");       // gdzie "user1" i user2" to typ referencjyjny, zajmują różne miejsce w pamięci(są różne)
            var user2 = GetUser("Edziu");       // gdzie "Edziu" i "Władziu" to typ wartościowy (łańcuch znaków)
            var user3 = GetUser("Władziu");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name) 
        {
            return new User(name);
        }
    }
}
