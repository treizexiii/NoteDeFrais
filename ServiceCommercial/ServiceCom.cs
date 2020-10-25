using System;
using System.Collections.Generic;

namespace ServiceCommercial
{   
    [Serializable]
    public class ServiceCom
    {
        public List<Commercial> EffectifsService { get; set; }
        public int IdService { get; set; }

        public ServiceCom(Service s)
        {
            EffectifsService = new List<Commercial>();
            s.AddNewService(this);
        }

        public void AddNewCormmercial(Commercial c)
        {
            EffectifsService.Add(c);
            c.IDCommercial = int.Parse(IdService.ToString() + EffectifsService.Count.ToString());
        }

        public void AddNoteService(Commercial c, DateTime d, int k)
        {
            TravelBill n = new TravelBill(d, c, k);
        }

        public void AddNote(Commercial c, DateTime d, decimal b)
        {
            NoteDeFrais n = new LunchBill(d, c, b);
        }

        public void AddNote(Commercial c, DateTime d, decimal b, int r)
        {
            NoteDeFrais n = new HotelBill(d, c, r, b);
        }

        public double AmountUncheck()
        {
            int numAmountUncheck=0;
            foreach (Commercial c in EffectifsService)
            {
                foreach (NoteDeFrais n in c.ListNotes)
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