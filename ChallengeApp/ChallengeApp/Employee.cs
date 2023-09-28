using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
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
