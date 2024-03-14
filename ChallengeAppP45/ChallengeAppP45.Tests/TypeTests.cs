namespace ChallengeAppP45.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntAreNotTheSameNumber()
        {
            // arrange
            int num1 = 1234;
            int num2 = 4321;

            // assert
            Assert.AreNotEqual(num1, num2);
        }

        [Test]
        public void IntAreTheSameNumber()
        {
            // arrange
            int num1 = 22;
            int num2 = 22;

            // assert
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void DoubleAreTheSameNumber()
        {
            // arrange
            double num1 = 1.25;
            double num2 = 1.25;

            // assert
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void DoubleAreNotTheSameNumber()
        {
            // arrange
            double num1 = 12.5;
            double num2 = 1.25;

            // assert
            Assert.AreNotEqual(num1, num2);
        }

        [Test]
        public void CharAreTheSame()
        {
            // arrange
            char letterA = 'a';
            char letterB = 'a';

            // assert
            Assert.AreEqual(letterA, letterB);
        }

        [Test]
        public void CharAreNotTheSame()
        {
            // arrange
            char letterA = 'a';
            char letterB = 'b';

            // assert
            Assert.AreNotEqual(letterA, letterB);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange
            var user1 = GetUser("Władek", "3345");
            var user2 = GetUser("Władziu", "5567");

            // assert
            Assert.AreNotSame(user1, user2);
        }

        [Test]
        public void UsersHaveDifferentLoginButTheSameName()
        {
            // arrange
            var user1 = GetUser("Władziu", "12345", "Władysław");
            var user2 = GetUser("Władek", "4321", "Władysław");

            // assert
            Assert.AreNotSame(user1.Login, user2.Login);
            Assert.AreSame(user2.Name, user1.Name);
        }

        [Test]
        public void UserAreNotTheSameYearOfBirth()
        {
            // arrange
            var user1 = GetUser(1980);
            var user2 = GetUser(1985);

            // assert
            Assert.AreNotEqual(user1.YearOfBirth, user2.YearOfBirth);
        }

        [Test]

        public void UserHasAllConstructorArgumentsAssigned()
        {
            // arrange
            string login = "Edziu";
            string password = "123456";
            string name = "Edward";
            int yob = 1980;

            // act
            var user1 = new User(login, password, name, yob);

            // assert
            Assert.AreEqual(login, user1.Login);
            Assert.AreEqual(password, user1.Password);
            Assert.AreEqual(name, user1.Name);
            Assert.AreEqual(yob, user1.YearOfBirth);
        }

        [Test]
        public void UserHasNoNameAndYearOfBirthArgumentsAssigned()
        {
            // arrange
            string login = "Radziu";
            string password = "876543";

            // act
            var user1 = new User(login, password);

            // assert
            Assert.AreEqual(user1.Login, login);
            Assert.AreEqual(user1.Password, password);
            Assert.IsNull(user1.Name);
            Assert.AreEqual(0, user1.YearOfBirth);
        }


        private User GetUser(int yob)
        {
            return new User(yob);
        }

        private User GetUser(string login, string password)
        {
            return new User(login);
        }

        private User GetUser(string login, string password, string name)
        {
            return new User(login, name);
        }

        private User GetUser(string login, string password, string name, int yob)
        {
            return new User(password);
        }
    }
}
