using System.Collections.Generic;

namespace ServiceCommercial
{
    public class ServiceCom
    {
        public List<Commercial> EffectifsService { get; set; }

        public ServiceCom()
        {
            EffectifsService = new List<Commercial>();
        }

        public void AddNewCormmercial(Commercial c)
        {
            EffectifsService.Add(c);
        }

        public double AmountUncheck()
        {
            int numAmountUncheck=0;
            foreach (Commercial c in EffectifsService)
            {
                foreach (NoteDeFrais n in c.NotesDeFrais)
                {
                    if (n.CheckNote != true)
                    {
                        numAmountUncheck += 1;
                    }
                }
            }
            return numAmountUncheck;
        }
    }
}