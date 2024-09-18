using System;

class Program
{
    static void Main()
    {
        int Num = 2;
        for (int e = 0; e <= 20; e++)
        {
            long res = (long)Math.Pow(Num, e);
            Console.WriteLine($"{Num}^{e} = {res}");
        }
    }
}

