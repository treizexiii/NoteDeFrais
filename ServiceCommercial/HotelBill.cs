using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCommercial
{
    public class HotelBill : NoteDeFrais
    {
        private int region;

        public int Region
        {
            set { this.region = value; }
        }

        public HotelBill(DateTime d, Commercial c, int r):base(d,c)
        {
            this.region = r;
        }
    }
}