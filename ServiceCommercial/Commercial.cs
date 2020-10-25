using System;
using System.Collections.Generic;

namespace ServiceCommercial
{
    [Serializable]
    public class Commercial
    {
        public List<NoteDeFrais> ListNotes { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PowerCar { get; set; }
        public char Cat { get; set; }
        public int IDCommercial { get; set; }

        public Commercial(ServiceCom sc, string fn, string ln, int a, int p, char c)
        {
            FirstName = fn;
            LastName = ln;
            Age = a;
            PowerCar = p;
            Cat = c;
            ListNotes = new List<NoteDeFrais>();
            sc.AddNewCormmercial(this);
        }

        public void addNoteCommercial(NoteDeFrais n)
        {
            ListNotes.Add(n);
            n.IDNote = int.Parse(IDCommercial.ToString() + ListNotes.Count.ToString());
        }

        public decimal CumulAmount(int year)
        {
            decimal totalAmount = 0;

            foreach (var noteDeFrais in ListNotes)
            {
                if (noteDeFrais.Date.Year == year)
                {
                    totalAmount += noteDeFrais.Amount;
                }
            }
            return totalAmount;
        }

        public override string ToString()
        {
            return $"ID : {IDCommercial} \nNom : {LastName} \nPrénom : {FirstName} \nPuissance de voiture {PowerCar} \nCatégorie : {Cat}";
        }
    }
}