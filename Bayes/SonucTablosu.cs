using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bayes
{
    class SonucTablosu
    {
        public double[,] Durumlar;

        public SonucTablosu(int SonucSayisi,int DurumSayisi)
        {
            Durumlar = new double[DurumSayisi, SonucSayisi];             
        }
        
    }
}
