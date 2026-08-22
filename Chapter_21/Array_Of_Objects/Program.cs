//Player[] Lobby = new Player[4];
//      or
Player[] Lobby = {  new Player("Ram", 20), 
                    new Player("Kim", 17), 
                    new Player("John Wick", 45), 
                    new Player("Mickey", 60) 
                 };
/*
 * Lobby[0].Drink();
 * 
Player Player_1 = new Player("Ram", 20);
Player Player_2 = new Player("Kim", 17);
Player Player_3 = new Player("John Wick", 45);
Player Player_4 = new Player("Mickey", 60);

Lobby[0] = Player_1;
Lobby[1] = Player_2;
Lobby[2] = Player_3;
Lobby[3] = Player_4;

Console.WriteLine(Lobby[0].name);
Console.WriteLine(Lobby[0].age);
*/


foreach (Player player in Lobby)
{
    Console.WriteLine(player.name);
}
class Player
{
    public String? name;
    public int age;
    public static int playerCount;
                                   
    public Player(String name, int age)
    {
        this.name = name;
        this.age = age;
        playerCount++;
    }

    public void Eat()
    {
        Console.WriteLine($"{name} is Eating");
    }
    public void Drink()
    {
        if (age < 18)
        {
            Console.WriteLine($"You are only {age} to drink, you are too young.");
        }
        else
        {
            Console.WriteLine("Cheers, Mate!");
        }
    }
    public void Sleep()
    {
        Console.WriteLine($"{name} is sleeping");
        age++;
        Console.WriteLine($"Congratulations, You are now {age}, You're old asf");
    }
    public void Shout()
    {
        Console.WriteLine($"Hoy! Putang ina mo! 'Yung mga barkada mo, nambabato sa bahay namin, ha! Huwag kayong magbabato sa bahay namin!");
    }
}
