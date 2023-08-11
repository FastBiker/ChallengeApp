using ChallengeApp;

Employee employee1 = new Employee("Piotr", "Dyduch", 42);
Employee employee2 = new Employee("Ignacy", "Daszyński", 36);
Employee employee3 = new Employee("Anastazja", "Billewiczówna", 28);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(7);
employee1.AddScore(4);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(6);
employee2.AddScore(3);

employee3.AddScore(10);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(7);


List<Employee> employees = new List<Employee>()
    {
        employee1, employee2, employee3,
    };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }
}

var name = employeeWithMaxResult.Name;
var surname = employeeWithMaxResult.Surname;
var age = employeeWithMaxResult.Age;
var result = employeeWithMaxResult.Result;
Console.WriteLine
    ("Pracownik z najwyższą liczną punktów:" + name + " " + surname + ", " + age + " lat," + result + " pkt.");

