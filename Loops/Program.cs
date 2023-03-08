using System;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"pink", "blue","purple"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) // Dizi temelli yapıları tek tek dönmeye yarar.
            {
                Console.WriteLine(kurs);
            }
        }
    }
}