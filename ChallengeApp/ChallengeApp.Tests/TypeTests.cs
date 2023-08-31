namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldCorrectMax()
        {
            // arrange
            var employee = new Employee("Michał", "Wołodyjowski");
            employee.AddGrade(4);
            employee.AddGrade(9);
            employee.AddGrade(2);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(9, statistics.Max);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldCorrectMin()
        {
            // arrange
            var employee = new Employee("Jan", "Sobieski");
            employee.AddGrade(7);
            employee.AddGrade(-4);
            employee.AddGrade(9);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(-4, statistics.Min);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldCorrectAverage()
        {
            // arrange
            var employee = new Employee("Azja", "Tuhajbejowicz");
            employee.AddGrade(9);
            employee.AddGrade(4);
            employee.AddGrade(-3);
            employee.AddGrade(-5);
            employee.AddGrade(-6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(-0.2f, statistics.Average);
        }
    }
}
