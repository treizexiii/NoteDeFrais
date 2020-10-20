using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCommercial
{
    public class TravelBill : NoteDeFrais
    {
        private int kilometers;

        private int Km
        {
            get { return this.kilometers; }
            set { this.kilometers = value; }
        }

        public TravelBill(DateTime d, Commercial c, int k) : base(d,c)
        {
            this.kilometers = k;
        }

        public override double CalculAmount()
        {
            double result;
            if(base.Commercial.PowerCar > 10)
            {
                result = this.kilometers * 0.3;
            }
            else if(base.Commercial.PowerCar >=5 && base.Commercial.PowerCar<=10)
            {
                result = this.kilometers * 0.2;
            }
            else
            {
                result = this.kilometers * 0.1;
            }
            return result;
        }

        public override string ToString()
        {
            return $"Date : {base.Date.ToShortDateString()} \nMontant à rembourser : {base.Amout} \nCommercial : {base.Commercial.LastName}";
        }
    }
}