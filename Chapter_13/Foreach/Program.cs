
String[] pangalan = { "Albert", "Isaac", "Mozart", "Michaelangelo", "Aristotle", "Beckie Pamintuan" };


foreach (String name in pangalan)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(pangalan[i]);
}
Console.WriteLine("\n");
for (int j = 0; j < pangalan.Length; j++)
{
    Console.WriteLine(pangalan[j]);
}


Random random = new Random();
Console.WriteLine("\n");
//int milliseconds = random.Next(200, 500);
int milliseconds = 166;


Thread.Sleep(milliseconds);


/*foreach (String word in pangalan)
{
    Console.Write("\n");
    foreach (char c in word)
    {
        Console.Write(c);
        Thread.Sleep(milliseconds);
        milliseconds = random.Next(200, 500);

    }
}
*/




















































































































Console.Write("C:\\Users\\Ram\\C-Sharp\\Foreach_Loop\\Foreach\\bin\\Debug\\net10.0\\Foreach.exe (process 42800) exited with code 0 (0x0).\r\nPress any key to close this window . . .");

Console.ReadKey();
Console.Clear();
String[] Lyrics = { 
    "Sapat na sa 'kin ang ganito oh", 
    "Ang pagmasdan ka sa malayo", 
    "Kapag kinausap walang masagot", 
    "Hininga'y lagot",
};

String[] LyricsV2 =
{
    "Hindi ko naman yata ikamamatay",
    "Kung hindi ko mahawakan ang iyong kamay",
    "Handa 'kong mabuhay sa aking kalokohan",
    "Kung wala ka sa 'king buhay walang kalungkutan"
};
foreach (String word in Lyrics)
    {
        Console.Write("\n");
        foreach (char c in word)
        {
            Console.Write(c);
            Thread.Sleep(milliseconds);

        }
    Thread.Sleep(1200);
    }
Console.Write("\n");
Thread.Sleep(1200);
foreach (String words in LyricsV2)
{
    Console.Write("\n");
    foreach (char d in words)
    {
        Console.Write(d);
        Thread.Sleep(milliseconds);

    }
    Thread.Sleep(1200);
}


