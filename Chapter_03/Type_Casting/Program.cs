//Type Casting
Console.WriteLine("-----Type Casting/Conversion-----");
double a = 1;
int b = Convert.ToInt32(a);
int c = 100;
double d = Convert.ToDouble(c);
string e = "%";//In order to convert a string to a char using Convert.ToChar it has to be a string with only one character
char f = Convert.ToChar(e);

Console.WriteLine("Double: " + a);
Console.WriteLine("Double to Integer: " + b);
Console.WriteLine("Integer to Double: " + d);
Console.WriteLine("Type: " + a.GetType());
Console.WriteLine("Char: " + f);

String situation = "True";
bool trueOrFalse = Convert.ToBoolean(situation);

Console.WriteLine("State: " + trueOrFalse);