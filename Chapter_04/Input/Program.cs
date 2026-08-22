//User Input
Console.WriteLine("-----User Input-----");
String? name;
Console.Write("Enter Name: ");
name = Console.ReadLine();
Console.Write("Enter Age: ");
int age = Convert.ToInt32(Console.ReadLine());
//Instead of: int ageInt = Convert.ToInt32(age);
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
