namespace ChallengeAppP45.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetSetOfGradesTheMinMethodShouldReturnLowestGrade() 
        {
            // arrange - przygotowanie danych
            var employee = new Employee("Motoko", "Kusanagi", 1995);
            employee.Addgrade(7);
            employee.Addgrade(8);
            employee.Addgrade(9);
            employee.Addgrade(10);
            employee.Addgrade(10);

            // act - wywołanie metody
            var statistics = employee.GetStatistics();

            // assert - sprawdzanie wyniku
            Assert.AreEqual(7, statistics.Min);
        }

        [Test]
        public void WhenEmployeeGetSetOfGradesTheMinMethodShouldReturnHighestGrade() 
        {
            var employee = new Employee("Batou", "Cyborg", 1988);
            employee.Addgrade(8);
            employee.Addgrade(8);
            employee.Addgrade(7);
            employee.Addgrade(8);
            employee.Addgrade(10);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetSetOfGradesTheAverageMethodShouldReturnCorrectAverageGrade() 
        {
            var employee = new Employee("Togusa", "Gits", 2002);
            employee.Addgrade(7);
            employee.Addgrade(8);
            employee.Addgrade(7);
            employee.Addgrade(9);
            employee.Addgrade(10);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(8.20, Math.Round(statistics.Average, 2));
        }
    }
}
