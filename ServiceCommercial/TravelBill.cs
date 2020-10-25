using System;

namespace ServiceCommercial
{
    [Serializable]
    public class TravelBill : NoteDeFrais
    {
        public int Kilometers { get; set; }

        public TravelBill(DateTime d, Commercial c, int k) : base(d, c)
        {
            Kilometers = k;
            Amount = CalculAmount();
        }

        public override decimal CalculAmount()
        {
            decimal result;
            if (Commercial.PowerCar > 10)
            {
                result = (decimal)(Kilometers * 0.3);
            }
            else if (Commercial.PowerCar >= 5 && Commercial.PowerCar <= 10)
            {
                result = (decimal)(Kilometers * 0.2);
            }
            else
            {
                result = (decimal)(Kilometers * 0.1);
            }
            return result;
        }

        public override string ToString()
        {
            return $"ID : {IDNote} Date : {Date.ToShortDateString()} \nMontant à rembourser : {Amount} \nCommercial : {Commercial.LastName}";
        }
    }
}