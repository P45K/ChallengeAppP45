namespace ChallengeAppP45.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetSetOfGradesTheMinMethodShouldReturnLowestGrade()
        {
            // arrange - przygotowanie danych
            var employee = new Employee("Motoko", "Kusanagi", 1995);
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(9);
            employee.AddGrade(10);
            employee.AddGrade(10);

            // act - wywołanie metody
            var statistics = employee.GetStatsForEach();

            // assert - sprawdzanie wyniku
            Assert.AreEqual(7, statistics.Min);
        }

        [Test]
        public void WhenEmployeeGetSetOfGradesTheMinMethodShouldReturnHighestGrade()
        {
            var employee = new Employee("Batou", "Cyborg", 1988);
            employee.AddGrade(8);
            employee.AddGrade(8);
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(10);

            var statistics = employee.GetStatsForEach();

            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetSetOfGradesTheAverageMethodShouldReturnCorrectAverageGrade()
        {
            var employee = new Employee("Togusa", "Gits", 2002);
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(7);
            employee.AddGrade(9);
            employee.AddGrade(10);

            var statistics = employee.GetStatsForEach();

            Assert.AreEqual(8.20, Math.Round(statistics.Average, 2));
        }
    }
}