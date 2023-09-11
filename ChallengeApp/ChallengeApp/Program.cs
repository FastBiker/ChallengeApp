using ChallengeApp;

Employee employee = new Employee("Andrzej", "Kmicic");

employee.AddGrade("3");
employee.AddGrade('9');
employee.AddGrade(4f);
employee.AddGrade("Piotr");
employee.AddGrade(-10f);
employee.AddGrade('h');
employee.AddGrade(16d);
employee.AddGrade(26L);
employee.AddGrade(7m);
employee.AddGrade(33);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N3}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
