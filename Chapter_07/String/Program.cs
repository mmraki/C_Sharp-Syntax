String name = "Hotdog Batumbakal";
/*
String num = "108443120119";
String code = "";

name = name.ToUpper();
Console.WriteLine(name);
name = name.ToLower();
Console.WriteLine(name);

num = num.Replace("1","*");
code = num.Replace("0", "5");



Console.WriteLine(num);
Console.WriteLine(code);
//                           ↓ the symbol that you will insert 
String user = name.Insert(0,"@");
//                        ↑ index position in the string
Console.WriteLine(user);

Console.WriteLine(name.Length);
//Check the length of the name
//                               ↓ how many you will take
String fname = name.Substring(0, 3);
//                            ↑ index ;position
Console.WriteLine(fname);

String lname = name.Substring(4, 6);

Console.WriteLine(lname);
*/


Console.Write("Enter text: ");
string input = Console.ReadLine().ToUpper();

// Replace letters with Morse code
string morse = input;
morse = morse.Replace("A", ".- ");
morse = morse.Replace("B", "-... ");
morse = morse.Replace("C", "-.-. ");
morse = morse.Replace("D", "-.. ");
morse = morse.Replace("E", ". ");
morse = morse.Replace("F", "..-. ");
morse = morse.Replace("G", "--. ");
morse = morse.Replace("H", ".... ");
morse = morse.Replace("I", ".. ");
morse = morse.Replace("J", ".--- ");
morse = morse.Replace("K", "-.- ");
morse = morse.Replace("L", ".-.. ");
morse = morse.Replace("M", "-- ");
morse = morse.Replace("N", "-. ");
morse = morse.Replace("O", "--- ");
morse = morse.Replace("P", ".--. ");
morse = morse.Replace("Q", "--.- ");
morse = morse.Replace("R", ".-. ");
morse = morse.Replace("S", "... ");
morse = morse.Replace("T", "- ");
morse = morse.Replace("U", "..- ");
morse = morse.Replace("V", "...- ");
morse = morse.Replace("W", ".-- ");
morse = morse.Replace("X", "-..- ");
morse = morse.Replace("Y", "-.-- ");
morse = morse.Replace("Z", "--.. ");
morse = morse.Replace(" ", " / ");

Console.WriteLine($"Morse Code: {morse}");