using System;

namespace ServiceCommercial
{
    [Serializable]
    public class NoteDeFrais
    {
        public bool CheckNote { get; set; }
        public Commercial Commercial { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int IDNote { get; set; }

        public NoteDeFrais(DateTime d, Commercial c)
        {
            Date = d;
            Commercial = c;
            c.addNoteCommercial(this);
            CheckNote = false;
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