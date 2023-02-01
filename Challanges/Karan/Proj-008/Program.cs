/*
    Alarm Clock - A simple clock where it plays a sound after X number of minutes/seconds or at a particular time.
*/
using System.Timers;

int time;
do
{
    try
    {
        Console.Write("Enter seconds: ");
        time = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Uh-Oh, enter a valid integer");
        continue;
    }
    break;
}while(true);

System.Timers.Timer timer = new System.Timers.Timer();
timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
timer.Interval = time * 1000;
timer.Enabled = true;
Console.ReadLine();

void OnTimedEvent(object source, ElapsedEventArgs e)
{
    Console.WriteLine("Wake up!!!");
    Console.Beep(5000, 1000);
    timer.Enabled = false;
    exit();
}

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}