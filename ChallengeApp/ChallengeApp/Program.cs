int age = 33;
string name = "Ewa";
bool kobieta = true;

// wersja 1
// Kobieta poniżej 30 lat
if(age < 30 && kobieta)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
// Ewa, lat 33
if(name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
// Niepełnoletni Mężczyzna
if(!kobieta && age < 18)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}

// wersja 2
if(kobieta)
{
    if(name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    if(name != "Ewa" && age < 30)
    {
        Console.WriteLine("Jakaś inna osoba");
    }
    else
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
if(!kobieta && age < 18)

{
    Console.WriteLine("Mężczyzna na emeryturze");
}
else
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}