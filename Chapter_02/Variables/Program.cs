//Variables
Console.WriteLine("-----Variables-----");
int x;    //Declaration
x = 100;  //Initialization

int y = 200; // Declaration + Initialization

int z = x + y;
//You can do this

Console.WriteLine("Int x = " + x);
Console.WriteLine("Int y = " + y);
Console.WriteLine("The sum of x + y is: " + z);

int num = 1;
double dbl = 2.5;
bool state = true;
char sym = '#';
String name = "Ram";
String lastName = "Lazaro";
String fullName = name + " " + lastName;

Console.WriteLine("Your Number is: " + num);
Console.WriteLine("Your Double is: " + dbl);
Console.WriteLine("The State is: " + state);
Console.WriteLine("Your Symbol is: " + sym);
Console.WriteLine("Your First Name is: " + name);
Console.WriteLine("Your Last Name is: " + lastName);
Console.WriteLine("Your Full Name is: " + fullName);

//Constant
Console.WriteLine("\n-----Constant-----");
const double pi = 3.14159;
Console.WriteLine(pi);