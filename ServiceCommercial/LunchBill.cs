using System;

namespace ServiceCommercial
{
    public class LunchBill : NoteDeFrais
    {
        public decimal Bill { get; set; }

        public LunchBill(DateTime d, Commercial c, decimal b) : base(d, c)
        {
            Bill = b;
            Amount = CalculAmount();
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
            if (result > Bill)
            {
                result = Bill;
            }
            return result;
        }

        public override string ToString()
        {
            return $"Date : {Date.ToShortDateString()} \nMontant à rembourser : {Amount} \nCommercial : {Commercial.LastName}";
        }
    }
}