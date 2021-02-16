using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    public class Etage
    {
        public string Floor { get; set; }
        public int CertificateLvl { get; set; }
        public Etage(string floor, int certificateLvl)
        {
            Floor = floor;
            CertificateLvl = certificateLvl; 
        }
    }
}
