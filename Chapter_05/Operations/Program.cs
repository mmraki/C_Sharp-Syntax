//Operations
Console.WriteLine("-----Operations-----");
double value = 1234;
double remainder = 0;
value += 1; //value = value + 1;
value -= 1; //value = value - 1;
value *= 3; //value = value * 3;
value /= 3;
Console.WriteLine("The Value is " + value);

remainder = value %= 2;
Console.WriteLine("The Remainder is " + remainder);

//Math
Console.WriteLine("\n-----Math Class-----");

double a = 25.5;
double b = Math.Pow(a, 2);
double c = Math.Sqrt(a);
double d = Math.Abs(a);
double e = Math.Round(a);
double f = Math.Ceiling(a);
double g = Math.Floor(a);
double h = Math.Max(a, b);
double i = Math.Min(a, b);


System.Console.WriteLine($"{a} raised to 2 is {b}");
Console.WriteLine($"The Squareroot of {a} is {c}");
Console.WriteLine($"The Absolute Value of {a} is {d}");
Console.WriteLine($"We Round {a} to the nearest number and the answer is {e}");
Console.WriteLine($"Round-up {a} and the answer is {f} ");
Console.WriteLine($"Round-down {a} and the answer is {g}");
Console.WriteLine($"The Maximum value between {a} and {b} is {h}");
Console.WriteLine($"The Minimun value between {a} ans {b} is {i}");

Console.Write("Enter side x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side y: ");
double y = Convert.ToDouble(Console.ReadLine());

double z = Math.Sqrt((x * x) + (y * y));
Console.WriteLine("The hypotenuse is " + z);