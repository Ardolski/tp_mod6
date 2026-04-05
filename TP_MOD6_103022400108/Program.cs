using System;

namespace TP_MODUL6_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SayaMusicTrack lagu1 = new SayaMusicTrack("Hanya Rindu");
            lagu1.IncreasePlayCount(5000);
            lagu1.PrintTrackDetails();

            Console.WriteLine("\n--- Mengetes Overflow ---");
            for (int i = 0; i < 220; i++)
            {
                lagu1.IncreasePlayCount(10000000); 
            }
            lagu1.PrintTrackDetails();
        }
    }
}