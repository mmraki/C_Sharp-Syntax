//Object = A instance or usage of a class
//Static = A signle copy for all instance

//                             ↓    ↓ Member Variable / Field
Player Player_1 = new Player("Ram", 20);
Player Player_2 = new Player("Kim", 17);
Player Player_3 = new Player("John Wick", 45);
//                             ↑           ↑ Member Variable / Field
Player Player_4 = new Player("Mickey");

Player_1.Eat();
Player_1.Drink();
Player_1.Sleep();
Player_1.Drink();
Player_1.Shout();

Console.WriteLine();

Player_2.Eat();
Player_2.Drink();
Player_2.Sleep();
Player_2.Drink();

Console.WriteLine();

Player_3.Eat();
Player_3.Drink();
Player_3.Sleep();
Player_3.Drink();

Console.WriteLine();

Player_4.Eat();
Player_4.Drink();

Console.WriteLine($"Number of players: {Player.playerCount}");

//Static = Becomes gojo
//If not static every instances has a copy
//If static only one original variable 
class Player
{
    //Member Variable or Field
    //      Holds Data for each object
    public String? name;
    public int age;
    public static int playerCount; // ← The only one hence Gojo
    //       ↑ only has one no copy per instances or objects, so all data that is  
    
    
    //Overloaded Contructors
    public Player(String name, int age) //Constructor    Assigns the value of an arguments to the parameters(fields or properties) of a class to make an object
    {
        this.name = name;
        this.age = age;
        playerCount++;
    }
    public Player(String name)      //Constructor
    {
        this.name = name;
        playerCount++;
    }

    public Player()     //Constructor
    {
        Console.WriteLine();
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
    public static void ShoutStatic()
    {
        Console.WriteLine($"Hoy! Putang ina mo! 'Yung mga barkada mo, nambabato sa bahay namin, ha! Huwag kayong magbabato sa bahay namin!");
    }
}





