using System.Reflection.Metadata;

namespace ChallengeAppP45.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShoultReturnResult()
        {
            // arrange
            var user = new User("Mietek", "12345");
            user.AddScore(5);
            user.AddScore(13);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(18, result);
        }
    }
}