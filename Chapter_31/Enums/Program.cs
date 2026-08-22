//Enums = a special "class" that contains a set of named integer constants.
Console.WriteLine(Planets.Pluto + " is a Planet");
Console.WriteLine(Planets.Pluto + " is planet " + (int)Planets.Pluto);
Console.WriteLine(Planets.Mercury + " is planet " + (int)Planets.Mercury);

String name = Planets.Earth.ToString();
int radius = (int)PlanetRadius.Earth;
double volume = Volume(PlanetRadius.Earth);

Console.WriteLine($"Planet: {name}");
Console.WriteLine($"Radius: {radius} km");
Console.WriteLine($"Volume: {volume} km^3");



static double Volume(PlanetRadius radius)
{
    double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
    return volume;
}
enum Planets
{
    Mercury = 1,
    Venus, 
    Earth, 
    Mars, 
    Jupiter, 
    Saturn, 
    Uranus, 
    Neptune, 
    Pluto
}
enum PlanetRadius
{
    Mercury = 2439,
    Venus = 6051,
    Earth = 6371,
    Mars = 3389,
    Jupiter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
}