using System;

namespace ServiceCommercial
{
    class Program
    {
        static void Main(string[] args)
        {
            Commercial c;
            c = new Commercial("Armand", "RAVE", 32, 8, 'B');
            NoteDeFrais f;
            f = new LunchBill(new DateTime(2020, 10, 22), c, 35);
            Console.WriteLine(f.CalculAmount());
        }


    }
}
