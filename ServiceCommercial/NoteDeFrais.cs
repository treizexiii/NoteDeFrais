using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCommercial
{
    public class NoteDeFrais
    {
        private DateTime date;
        private double amount;
        private bool checkNote = false;
        private Commercial commercial;
        private int numAmount;

        public double Amout
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public bool Checknote
        {
            get { return this.checkNote; }
            set { this.checkNote = value; }
        }
        public Commercial Commercial
        {
            get { return this.commercial; }
            set { this.commercial = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
        }

        public NoteDeFrais(DateTime d, Commercial c)
        {
            this.date = d;
            this.commercial = c;
            c.addNote(this);
        }

        public void SetAmount()
        {
            this.amount = CalculAmount();
        }

        virtual public double CalculAmount()
        {
            return 0;
        }

        public bool SetCheck()
        {
            if(this.amount==0)
            {
                this.checkNote = true;
            }
            return checkNote;
        }

        public override string ToString()
        {
            return $"Date : {date.ToShortDateString()} \nMontant à rembourser : {amount} \nStatus : {checkNote.ToString()} \nCommercial : {commercial.LastName}";
        }
    }
}