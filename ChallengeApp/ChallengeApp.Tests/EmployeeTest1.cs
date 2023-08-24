namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Claus", "von Stauffenberg", 37);
            employee.AddScore(4);
            employee.AddScore(9);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(13, result);
        }
        [Test]
        public void WhenEmployeeCollectThreeScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Heinrich", "von Lehndorff", 35);
            employee.AddScore(7);
            employee.AddScore(-4);
            employee.AddScore(9);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(12, result);
        }
        [Test]
        public void WhenEmployeeCollectFiveScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Erwin", "Rommel", 53);
            employee.AddScore(-5);
            employee.AddScore(-6);
            employee.AddScore(4);
            employee.AddScore(4);
            employee.AddScore(9);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(6, result);
        }
        [Test]
        public void WhenEmployeeCollectFiveNegativeScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Martin", "Bormann", 45);
            employee.AddScore(-3);
            employee.AddScore(-5);
            employee.AddScore(-7);
            employee.AddScore(-2);
            employee.AddScore(-8);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(-25, result);
        }

    }
}