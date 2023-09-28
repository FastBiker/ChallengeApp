using ChallengeApp;

Console.WriteLine("Witamy w Programie 'My best Employees' do oceny Pracowników");
Console.WriteLine("======================================");
Console.WriteLine();


var employee = new Employee("Jan", "Skrzetuski");

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try 
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2} => {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");