using System;
using System.Threading;

class BSCWBufferingTool
{
    static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        // This program is a tool for speedrunning The Legend of Zelda : Breath of the Wild, it allows you to be told when to buffer during a Buffered SCW.
        // The time needed to execute the while loop is meant to compensate the lag frames.
        int frames;
        do
        {
            Console.WriteLine("How many frames do you want to buffer every second? (integer between 2 and 28)");
            frames = Convert.ToInt32(Console.ReadLine());
        } while (frames < 2 || frames > 28);

        int soundFrequency;
        do
        {
            Console.WriteLine("Which frequency (in Hertz) do you want to hear? (integer between 37 and 32767)");
            soundFrequency = Convert.ToInt32(Console.ReadLine());
        } while (soundFrequency < 37 || soundFrequency > 32767);

        decimal bufferingTime = frames * (100 / 3);
        Console.WriteLine("Buffer when you hear the sound.");
        Console.WriteLine("Press any key to end program.");
        
        while (true)
        {
            Console.Beep((int)bufferingTime, soundFrequency);
            Thread.Sleep((int)(1000 - bufferingTime));
        }
    }
}
