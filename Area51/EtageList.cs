using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    public class EtageList
    {
        List<Etage> etager = new List<Etage>();
        public EtageList()
        {
            Etage St = new Etage("St", 0);
            Etage B1 = new Etage("B1", 1);
            Etage B2 = new Etage("B2", 2);
            Etage B3 = new Etage("B3", 3);

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
