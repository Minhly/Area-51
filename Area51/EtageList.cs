using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    class EtageList
    {
        List<Etage> etager = new List<Etage>();
        public EtageList()
        {
            Etage St = new Etage("St", 1);
            Etage B1 = new Etage("B1", 2);
            Etage B2 = new Etage("B2", 3);
            Etage B3 = new Etage("B3", 4);

            etager.Add(St);
            etager.Add(B1);
            etager.Add(B2);
            etager.Add(B3);

        }

        public List<Etage> GetEtager()
        {
            return etager;
        }
    }
}
