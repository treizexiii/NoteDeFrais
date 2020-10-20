using System;

namespace ServiceCommercial
{
    public class NoteDeFrais
    {
        public decimal Amount { get; set; }

        public bool CheckNote { get; set; }

        public Commercial Commercial { get; set; }

        public DateTime Date { get; set; }

        public NoteDeFrais(DateTime d, Commercial c)
        {
            Date = d;
            Commercial = c;
            c.addNote(this);
            CheckNote = false;
        }

        public void SetAmount()
        {
            Amount = CalculAmount();
        }

        virtual public decimal CalculAmount()
        {
            return 0;
        }

        public bool SetCheck()
        {
            if (Amount == 0)
            {
                CheckNote = true;
            }
            return CheckNote;
        }

        public override string ToString()
        {
            return $"Date : {Date.ToShortDateString()} \nMontant à rembourser : {Amount} \nStatus : {CheckNote.ToString()} \nCommercial : {Commercial.LastName}";
        }
    }
}