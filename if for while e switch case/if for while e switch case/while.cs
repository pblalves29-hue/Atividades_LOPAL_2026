using System;

class Program
{
    static void Main()
    {
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine($"\nTabuada do {i}:");

            int j = 1;

            while (j <= 10)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
                j++; 
            }

            i++; 
        }
    }
}
