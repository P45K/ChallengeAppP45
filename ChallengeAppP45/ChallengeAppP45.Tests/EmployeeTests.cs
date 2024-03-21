namespace ChallengeAppP45.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetSetOfCharTypeGradesThenShouldReturnCorrectAverageValue()
        {
            // arrange - przygotowanie danych
            var employee = new Employee("Motoko", "Kusanagi", 1995);
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('c');
            employee.AddGrade('B');

            // act - wywołanie metody
            var statistics = employee.GetStats();

            // assert - sprawdzanie wyniku
            Assert.AreEqual(76, statistics.Average);
        }

        [Test]
        public void WhenEmployeeGetSetOfGradesThenShouldReturnCorrectMaxValue()
        {
            var employee = new Employee("Boma", "Gits", 1995);
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('c');
            employee.AddGrade('B');

            var statistics = employee.GetStats();

            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetSetOfGradesThenShouldReturnCorrectMinValue()
        {
            var employee = new Employee("Ishikawa", "Gits", 1995);
            employee.AddGrade('e');
            employee.AddGrade('b');
            employee.AddGrade(20.01);
            employee.AddGrade('c');
            employee.AddGrade('D');

            var statistics = employee.GetStats();

            Assert.AreEqual(20, statistics.Min);
        }

        [Test]
        public void WhenEmployeeGetSetOfGradesThenShouldReturnCorrectAverageLetter()
        {
            var employee = new Employee("Saito", "Gits", 1995);
            employee.AddGrade("22");
            employee.AddGrade("44");
            employee.AddGrade("55");
            employee.AddGrade("66");
            employee.AddGrade("B");

            var statistics = employee.GetStats();

            Assert.AreEqual('C', statistics.AverageLetter);
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

            var statistics = employee.GetStats();

            Assert.AreEqual(8.20, Math.Round(statistics.Average, 2));
        }
    }
}