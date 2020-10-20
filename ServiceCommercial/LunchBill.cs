using System;

namespace ServiceCommercial
{
    public class LunchBill : NoteDeFrais
    {
        public decimal Bill { get; set; }

        public LunchBill(DateTime d, Commercial c, decimal b) : base(d, c)
        {
            this.Bill = b;
        }

        public override decimal CalculAmount()
        {
            decimal result = 0;
            switch (base.Commercial.Cat)
            {
                case 'A':
                    result = 25;
                    break;
                case 'B':
                    result = 22;
                    break;
                case 'C':
                    result = 20;
                    break;
            }
            if (result > this.Bill)
            {
                result = this.Bill;
            }
            return result;
        }

        public override string ToString()
        {
            return $"Date : {base.Date.ToShortDateString()} \nMontant à rembourser : {this.Bill} \nCommercial : {base.Commercial.LastName}";
        }
    }
}