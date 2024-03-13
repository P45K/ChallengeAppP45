namespace ChallengeAppP45.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPositivePoints_ShouldReturnCorrectResult()
        {
            // arrange
            var user = new User("Mietek", "13131313");
            user.AddPositivePoints(7);
            user.AddPositivePoints(10);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(17, result);
        }

        [Test]
        public void WhenUserCollectTwoSetOfPositivePointsAndtwoSetofNegativePoints_ShouldReturnCorrectResult()
        {
            // arrange
            var user = new User("Mietek", "13131313");
            user.AddPositivePoints(7);
            user.AddPositivePoints(5);
            user.AddNegativePoints(-5);
            user.AddNegativePoints(-7);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhenUserCollectFiveSetOfNegativePoints_ShouldReturnCorrectResult()
        {
            // arrange
            var user = new User("Mietek", "13131313");
            user.AddNegativePoints(-2);
            user.AddNegativePoints(-1);
            user.AddNegativePoints(-2);
            user.AddNegativePoints(-1);
            user.AddNegativePoints(-1);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(-7, result);
        }

        [Test]
        public void WhenUserNotCollectAnyPoints_ShouldReturnCorrectResult()
        {
            // arrange
            var user = new User("Mietek", "13131313");

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}