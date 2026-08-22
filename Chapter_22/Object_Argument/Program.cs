Player[] Lobby = {  new Player("Ram", 20),
                    new Player("Kim", 17),
                    new Player("John Wick", 45),
                    new Player("Mickey", 60)
                 };

Player Player_5 = Duplicate(Lobby[0]);


static Player Duplicate(Player player)
{

    return new Player(player.name, player.age);
}

static void Fixer(Player player, String name, int age){
    player.name = name;
    player.age = age;
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
            Console.WriteLine($"Cheers, {name} Mate!");
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