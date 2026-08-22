using System.Xml.Schema;


//Auto Implementation = shortcut when no additional logic to the value is needed

Vehicle Car = new Vehicle("Convertible");
Console.WriteLine(Car.Type);
class Vehicle
{
    
     //Field
     //private String type;

     //public string Type
     //{
     //    get { return type; }
     //    set { type = value; }
     //}
     
    public String Type { get; set; }
   

    //Constructor
    public Vehicle(String type)
    {
        this.Type = type;
    }
}