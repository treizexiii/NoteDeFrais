using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCommercial
{
    public class LunchBill : NoteDeFrais
    {
        private double bill;

        public double Bill
        {
            get { return bill; }
            set { bill = value; }
        }

        public LunchBill(DateTime d, Commercial c, double b) : base(d,c)
        {
            b = this.bill;
        }

        public override double CalculAmount()
        {
            double result;

            if (base.Commercial.Cat=='A')
            {
                result = 25;
            }
            else if(base.Commercial.Cat=='B')
            {
                result = 22;
            }
            else if(base.Commercial.Cat=='C')
            {
                result = 20;
            }

            return result;
        }

        public override string ToString()
        {
            return $"Date : {base.Date.ToShortDateString()} \nMontant à rembourser : {this.bill} \nCommercial : {base.Commercial.LastName}";
        }
    }
}