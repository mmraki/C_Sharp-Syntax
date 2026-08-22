//Interface = A contract or a condition that is signed or implemented
//            if the contract is accepted, those methods or properties
//            must be present in every class that implements it


Rabbit rabbit = new Rabbit();
Hawk hawk = new Hawk();
Fish fish = new Fish();

rabbit.run();
hawk.hunt();

fish.hunt();
fish.run();

interface IPrey
{
    void run();
 
}
interface IPredator
{
    void hunt();
}

class Rabbit : IPrey
{
    public void run()
    {
        Console.WriteLine("The Rabbit ran away");
    }
}
class Hawk : IPredator
{
    public void hunt()
    {
        Console.WriteLine("The Hawk hunted for food");
    }
}
class Fish : IPredator, IPrey
{
    public void hunt()
    {
        Console.WriteLine("The fish ate something");
    }
    public void run()
    {
        Console.WriteLine("The fish swam away");
    }
}