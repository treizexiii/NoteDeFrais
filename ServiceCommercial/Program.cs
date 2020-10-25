using System;

namespace ServiceCommercial
{
    class Program
    {
        static void Main(string[] args)
        {
            Service s = PersistService.Load("service.sr");

            ServiceCom sc1 = s.ListService[0];
            
            Commercial c3;
            c3 = new Commercial(sc1, "Dupond", "Jean", 35, 7, 'B');
            sc1.AddNoteService(c3, new DateTime(2013, 11, 15), 100);
            sc1.AddNote(c3, new DateTime(2013, 11, 21), (decimal)15.5);
            sc1.AddNote(c3, new DateTime(2013, 11, 25), 105, 2);
            sc1.AmountUncheck();
            Console.WriteLine(sc1.IdService.ToString());
            NoteDeFrais n = new TravelBill(new DateTime(2020, 10, 24), c3, 150);
            Console.WriteLine(n.ToString());

            PersistService.Save(s, "service.sr");

            Console.WriteLine(c3.CumulAmount(2013));
            Console.WriteLine(c3.ToString());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
