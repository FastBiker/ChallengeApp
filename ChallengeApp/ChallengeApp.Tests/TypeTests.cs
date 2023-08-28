namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoNameOfCitiesShouldDefferent()
        {
            // arrange
            string city1 = "Warszawa";
            string city2 = "Kraków";

            // act
            // assert
            Assert.AreNotEqual(city1, city2);
        }

        [Test]
        public void TwoFloatingPointNumbersShouldDefferent()
        {
            // arrange
            float number3 = 67.98f;
            float number4 = 0.5746362f;

            // act
            // assert
            Assert.AreNotEqual(number3, number4);
        }

        [Test]
        public void TwoNaturalNumbersShouldDefferent()
        {
            // arrange
            int number1 = 16;
            int number2 = 24;

            // act
            // assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Piotr","Szczerbaty", 42);
            var employee2 = GetEmployee("Tomasz", "Wierny", 61);

            // act
            // assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name,surname, age);
        }
    }
}
