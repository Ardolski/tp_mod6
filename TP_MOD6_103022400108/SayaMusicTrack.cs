using System;
using System.Diagnostics;

namespace TP_MODUL6_NIM
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh null");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            
            Debug.Assert(count <= 10000000, "Input penambahan maksimal 10.000.000");

            try
            {
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi kesalahan: Play count melebihi batas maksimum (Overflow)!");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {id} | Title: {title} | Play Count: {playCount}");
        }
    }
}