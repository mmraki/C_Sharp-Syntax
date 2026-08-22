Vehicle Car = new Vehicle(1000);



//What if
//Car.speed = 1000;
//setting a new speed value
//to prevent this from happening
Car.Speed = 90000;
Console.WriteLine(Car.Speed);
class Vehicle
{
    //we can set this to private
    private int speed;

    public Vehicle(int velocity){
        this.speed = velocity;
    }
    //Property
    public int Speed
    {
        get { return speed; }//read
        set                  //write
        {
            if (value > 500)
            {
                speed = 250;
            }
            else
            {
                speed = value;
            }
            
        }
    }
}