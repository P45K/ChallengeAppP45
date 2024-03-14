namespace ChallengeAppP45.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // arrange
            var user1 = GetUser("Edziu");
            var user2 = GetUser("Władziu");

            // act


            // assert

        }

        private User GetUser(string name) 
        {
            return new User(name);
        }
    }
}
