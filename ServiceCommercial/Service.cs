using System;
using System.Collections.Generic;

namespace ServiceCommercial
{
    [Serializable]
    public class Service
    {
        public List<ServiceCom> ListService { get; set; }

        public Service()
        {
            ListService = new List<ServiceCom>();
        }

        public void AddNewService(ServiceCom sc)
        {
            ListService.Add(sc);
            sc.IdService = ListService.Count;
            
        }
    }
}
