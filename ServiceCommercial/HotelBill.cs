using System;

namespace ServiceCommercial
{
    public class HotelBill : NoteDeFrais
    {
        public int Region { get; set; }
        public decimal Bill { get; set; }

        public HotelBill(DateTime d, Commercial c, int r, decimal b) : base(d, c)
        {
            Region = r;
            Bill = b;
        }

        public override decimal CalculAmount()
        {
            decimal result = 0;
            switch (Commercial.Cat)
            {
                case 'A':
                    result = 65;
                    break;
                case 'B':
                    result = 55;
                    break;
                case 'C':
                    result = 50;
                    break;
            }
            if (Region == 1)
            {
                result *= (decimal)0.90;
            }
            else if (Region == 3)
            {
                result *= (decimal)1.15;
            }
            if (result > Bill)
            {
                result = Bill;
            }
            return result;
        }

        public override string ToString()
        {
            return $"Date : {Date.ToShortDateString()} \nMontant à rembourser : {Bill} \nCommercial : {Commercial.LastName}";
        }
    }
}