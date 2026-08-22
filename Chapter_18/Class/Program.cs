using Class;


//Class = A Group of related code
//        Blueprint for Objects (OOP)

Messages.Greet();
Messages.Surprise();
Messages.Goodbye();

Console.WriteLine();

Status.Hot();
Status.Cold();
Status.Warm();

class Status()
{
    public static void Hot()
    {
        Console.WriteLine("It’s hot in the Philippines.");
    }
    public static void Cold()
    {
        Console.WriteLine("Its never cold in the Philippines.");
    }
    public static void Warm(){
        Console.WriteLine("Sometimes.");
    }
}



