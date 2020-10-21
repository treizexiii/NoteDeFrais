using System;

namespace ServiceCommercial
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCom sc;
            Commercial c1;
            sc = new ServiceCom();
            c1 = new Commercial("Dupond", "Jean", 35, 7, 'B');
            sc.AddNewCormmercial(c1);
            sc.AddNoteService(c1, new DateTime(2013, 11, 15), 100);
            sc.AddNote(c1, new DateTime(2013, 11, 21), (decimal)15.5);
            sc.AddNote(c1, new DateTime(2013, 11, 25), 105, 2);
            sc.AmountUncheck();
            c1.CumulAmount(2013);
            Console.ReadKey();
        }


    }
}
