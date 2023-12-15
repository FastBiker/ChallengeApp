using ChallengeApp;

Console.WriteLine("Witamy w Programie 'My best Employees' do oceny Pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Możesz ocenić PRACOWNIKA używając liczby od 0 do 100, gdzie 100 oznacza najwyższą ocenę a 0 najniższą,");
Console.WriteLine("albo używając liter 'a', 'b', 'c', 'd' (dużych lub małych), gdzie 'a' oznacza najwyższą ocenę, a 'd' najniższą");
Console.WriteLine("Wprowdź 'q', aby uzyskać statystyki ocen, albo przejść do oceny dyrektora");
Console.WriteLine("You can evaluate your EMPLOYEE, using a number from 0 to 100, where 100 means the best/highest grade and 0 the worst/lowest");
Console.WriteLine("or using leterrs 'a', 'b', 'c', 'd', 'e' (big or small), where 'a' means the best/highest grade and 'e' the worst/lowest");
Console.WriteLine("Enter 'q' to recive statistcs of grades");
Console.WriteLine();

var employee = new EmployeeInFile("Jan", "Skrzetuski", 'M', 34);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2} => {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


//var supervisor = new Supervisor("Michał", "Korybut-Wiśniowiecki", 'M', 58);

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę dyrektora: ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        supervisor.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}

//var statistics1 = supervisor.GetStatistics();
//Console.WriteLine($"Average: {statistics1.Average:N2} => {statistics1.AverageLetter}");
//Console.WriteLine($"Min: {statistics1.Min}");
//Console.WriteLine($"Max: {statistics1.Max}");