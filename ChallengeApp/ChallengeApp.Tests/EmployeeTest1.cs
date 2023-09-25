namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void WhenEmployeeCollectCharLetterGrades_ShouldCorrectStatistics()
        {
            // arrange
            var employee = new Employee("Micha³", "Wo³odyjowski");
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('c');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(60, statistics.Min);
            Assert.AreEqual(Math.Round(80.00, 2), Math.Round(statistics.Average, 2));
            Assert.AreEqual('A' , statistics.AverageLetter);
        }
        [Test]
        public void WhenEmployeeCollectStringLetterGrades_ShouldCorrectStatisyics()
        {
            // arrange
            var employee = new Employee("Jan", "Sobieski");
            employee.AddGrade("B");
            employee.AddGrade("D");
            employee.AddGrade("e");

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(Math.Round(46.67, 2), Math.Round(statistics.Average, 2));
            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void WhenEmployeeCollectDiferentGrades_ShouldCorrectStatistics()
        {
            // arrange
            var employee = new Employee("Azja", "Tuhajbejowicz");
            employee.AddGrade(150);
            employee.AddGrade('c');
            employee.AddGrade(78);
            employee.AddGrade("B");
            employee.AddGrade(-16);
            employee.AddGrade('9');
            employee.AddGrade("93");
            employee.AddGrade(34f);
            employee.AddGrade(76d);
            employee.AddGrade(99L);
            employee.AddGrade(16m);
            employee.AddGrade("Mama");


            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(99, statistics.Max);
            Assert.AreEqual(9, statistics.Min);
            Assert.AreEqual(Math.Round(60.56, 2), Math.Round(statistics.Average, 2));
            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}