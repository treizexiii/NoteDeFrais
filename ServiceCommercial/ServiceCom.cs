using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCommercial
{
    public class ServiceCom
    {
        private List<Commercial> effectifsService;

        protected int numAmountUncheck;

        public List<Commercial> EffectifsService
        {
            get { return effectifsService; }
            set { effectifsService = value; }
        }

        public ServiceCom()
        {
            this.effectifsService = new List<Commercial>();
        }

        public void AddNewCormmercial(Commercial c)
        {
            effectifsService.Add(c);
        }

        public double AmountUncheck()
        {
            foreach(Commercial c in effectifsService)
            {
                foreach(NoteDeFrais n in c.MyList)
                {
                    if(n.Checknote != true)
                    {
                        numAmountUncheck += 1;
                    }
                }
            }
            return numAmountUncheck;
        }
    }
}