using ChallengeApp;

Employee employee = new Employee("Andrzej", "Kmicic");

employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(9);
employee.AddGrade(6);
employee.AddGrade(-10);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N3}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
