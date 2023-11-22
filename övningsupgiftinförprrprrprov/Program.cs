using System;

namespace testestestest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            for (int i = 0; i < namn.Length; i++) 
            {
                Console.WriteLine("Skriv namn nummer " + (i+1));
                namn[i] = Console.ReadLine();
            }
            Console.WriteLine("Dina fem namn var: ");
            for(int i = 0; i < namn.Length; i++) 
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
