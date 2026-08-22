using System;
using System.Threading;

Thread mainThread = Thread.CurrentThread;

mainThread.Name = "Main Thread";
Thread thread1 = new Thread(() => Cdown("1"));
Thread thread2 = new Thread(() => Cup("2"));

thread1.Start();
thread2.Start();

static void Cdown(String Version){
    for (int i = 10; i >= 0; i-- )
    {
        Console.WriteLine($"Timer: {i}");
        Thread.Sleep(1000);
    }
    Console.WriteLine("Complete");
}
static void Cup(String Version)
{
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"Timer 2: {i}");
        Thread.Sleep(1000);
    }
    Console.WriteLine("Complete");
}