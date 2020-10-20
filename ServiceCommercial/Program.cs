using System;

namespace ServiceCommercial
{
    class Program
    {
        static void Main(string[] args)
        {
            Commercial c;
            c = new Commercial("Armand", "RAVE", 32, 8, 'A');
            NoteDeFrais f;
            f = new TravelBill(new DateTime(2020, 10, 19), c, 250);
           Console.WriteLine(f.CalculAmount());
        }


    }
}
