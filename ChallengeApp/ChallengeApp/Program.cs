int age;
string name;
bool kobieta = true;

if (age < 30 && kobieta)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!kobieta && age < 18)
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}
else
{
    Console.WriteLine("każda inna kobieta lub każdy inny mężczyzna");
}


