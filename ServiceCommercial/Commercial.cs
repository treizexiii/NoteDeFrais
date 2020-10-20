using System.Collections.Generic;

namespace ServiceCommercial
{
    public class Commercial
    {
        public List<NoteDeFrais> NotesDeFrais { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int PowerCar { get; set; }
        public char Cat { get; set; }

        public Commercial(string fn, string ln, int a, int p, char c)
        {
            FirstName = fn;
            FirstName = ln;
            Age = a;
            PowerCar = p;
            Cat = c;
            NotesDeFrais = new List<NoteDeFrais>();
        }
        public void addNote(NoteDeFrais n)
        {
            NotesDeFrais.Add(n);
        }

        public decimal CumulAmount(int year)
        {
            decimal totalAmount = 0;

            foreach (var noteDeFrais in NotesDeFrais)
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
            return $"Nom : {LastName} \nPrénom : {FirstName} \nPuissance de voiture {PowerCar} \nCatégorie : {Cat}";
        }
    }
}