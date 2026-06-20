using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bayes
{
    class Ornek // Herbir Örnek 
    {
        public string[] Ozellikler; // Örneğe ait özellikler
        public string Sonuc; // Bu örneğin sonucu

        //Constructor
        public Ornek(int OzellikSayisi, int DurumSayisi,int SonucSayisi,Random r,double[] SonucSayilari,SonucTablosu[] OzellikSonuc)
        {
            Ozellikler = new string[OzellikSayisi]; // Özellik dizisi
            int _son = r.Next(SonucSayisi);
            SonucSayilari[_son]++;
            //Random özellik dizisi dolduruluyor
            for (int i = 0; i < OzellikSayisi; i++)
            {
                int temp = r.Next(DurumSayisi);
                Ozellikler[i] = "Durum("+i+")_" + temp;
                OzellikSonuc[i].Durumlar[temp, _son]++;
            }
            Sonuc = "Sonuc_" + _son;
        }
    }
}
