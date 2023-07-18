int age = 13;
string name = "Marian";
bool isWoman = false;

if (age < 30 && isWoman)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!isWoman && age < 18)
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}
else
{
    Console.WriteLine("każda inna kobieta lub każdy inny mężczyzna");
}
