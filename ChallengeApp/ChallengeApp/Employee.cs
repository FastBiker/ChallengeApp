namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, char sex, int age)
            : base(name, surname, sex, age) 
        {
        }

        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Grade value outside the valid range. Enter a grade using a number from 0 to 100");
            }          
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    if (float.TryParse(grade.ToString(), out float result))
                    {
                        this.AddGrade(result);
                        break;
                    }
                    else
                    {
                        throw new Exception("Char is not float and letter grade");
                    }
            }
        }
            public void AddGrade(string grade)
        {
            if(float.TryParse(grade,out float result))
            {
                this.AddGrade(result);
            }
            else if(char.TryParse(grade, out char result1))
            {
                this.AddGrade(result1);
            }
            else
            {
                throw new Exception("String is not float and letter grade");
            }
        } 
        public void AddGrade(int grade)
        {
            float valueInFloat = grade;
            this.AddGrade(valueInFloat);
        }
        public void AddGrade(long grade)
        {
            float valueInFloat = grade;
            this.AddGrade(valueInFloat);
        }
        public void AddGrade(short grade)
        {
            float valueInFloat = grade;
            this.AddGrade(valueInFloat);
        }
        public void AddGrade(double grade)
        {
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }
        public void AddGrade(decimal grade)
        {
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }
            
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        } 
    }
}
