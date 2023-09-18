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

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine($"Average: {statistics2.Average:N3}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}");
