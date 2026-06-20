using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }
        Ornek[] Ornekler;
        int OrnekSayisi,OzellikSayisi,DurumSayisi,SonucSayisi;
        SonucTablosu[] OzellikSonuc;
        double[] SonucSayilari;
        Random r;
        private void Btn_Rastgele_Click(object sender, EventArgs e)
        {
            // Değişkenler
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            treeView1.Nodes[0].Nodes.Clear();
            OrnekSayisi = (int)Nud_OrnekSayisi.Value;
            OzellikSayisi = (int)Nud_OzellikSayisi.Value;
            DurumSayisi = (int)Nud_OzellikDurumSayisi.Value;
            SonucSayisi = (int)Nud_SonucSayisi.Value;
            Ornekler = new Ornek[OrnekSayisi];
            OzellikSonuc = new SonucTablosu[OzellikSayisi]; // Sonuçların tutulduğu tablo
            SonucSayilari = new double[SonucSayisi];

            for (int i = 0; i < OzellikSayisi; i++)
            {
                OzellikSonuc[i] = new SonucTablosu(SonucSayisi, DurumSayisi);
            }

            //Ağaca Ekleme
            for (int i = 0; i < OrnekSayisi; i++)
            {
                Ornekler[i] = new Ornek(OzellikSayisi, DurumSayisi, SonucSayisi,r,SonucSayilari,OzellikSonuc);
                treeView1.Nodes[0].Nodes.Add("Ornek_" + i);
                string OrnekStr = "";
                for (int j = 0; j < OzellikSayisi; j++)
                {
                    OrnekStr += Ornekler[i].Ozellikler[j] + " , ";
                }
                treeView1.Nodes[0].Nodes[i].Nodes.Add(OrnekStr + Ornekler[i].Sonuc.ToUpper());
            }
   
            //Olasılıkları hesapla
            for (int i = 0; i < OzellikSayisi; i++)
            {
                for (int j = 0; j < DurumSayisi; j++)
                {
                    for (int k = 0; k < SonucSayisi; k++)
                    {
                        OzellikSonuc[i].Durumlar[j, k] = OzellikSonuc[i].Durumlar[j, k] / SonucSayilari[k];
                    }
                }
            }
            //Datagrid1 kolon ekle
            for (int i = 0; i < OzellikSayisi; i++)
            {
                for (int j = 0; j < DurumSayisi; j++)
                {
                    DataGridViewColumn cl = new DataGridViewColumn();
                    cl.HeaderText = "Durum(" + i + ")_"+j;
                    DataGridViewCell cell = new DataGridViewTextBoxCell();                                       
                    cl.CellTemplate = cell;
                    cl.ReadOnly = true;
                    dataGridView1.Columns.Add(cl);                                    
                }
            }
            //Datagrid1-2 satir ekle
            for (int i = 0; i < SonucSayisi; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                dataGridView1.Rows.Add(r);
                DataGridViewRow r2 = new DataGridViewRow();
                dataGridView2.Rows.Add(r2);               
                
            }

            //Datagrid1 hücreleri doldur
            int hucreSayici = 0;
            for (int i = 0; i < SonucSayisi; i++)
            {
                for (int j = 0; j < OzellikSayisi; j++)
                {
                    for (int k = 0; k < DurumSayisi; k++)
                    {
                        dataGridView1.Rows[i].Cells[hucreSayici].Value = OzellikSonuc[j].Durumlar[k,i];
                        hucreSayici++;
                    }
                }
                hucreSayici = 0;
            }
            dataGridView1.AutoResizeColumns();

            //Sonuçları datagrid2 ye yükle
            for (int i = 0; i < SonucSayisi; i++)
            {
                SonucSayilari[i] /= OrnekSayisi;
                dataGridView2.Rows[i].Cells[0].Value = SonucSayilari[i];                
            }
            Btn_RasgeleOrnek.Enabled = true;    

                        
        }

        private void Btn_RasgeleOrnek_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            int[] RandOrnek = new int[OzellikSayisi];
            double[] _sonuclar = new double[SonucSayisi];
            //tablo değerlerini 1 yap
            for (int j = 0; j < SonucSayisi; j++)
            {
                _sonuclar[j] = 1; 
            }

            //Random örnek oluştur
            for (int i = 0; i < OzellikSayisi; i++)
            {
                DataGridViewRow r3 = new DataGridViewRow();
                dataGridView3.Rows.Add(r3);
                int RanO = r.Next(DurumSayisi);
                RandOrnek[i] = RanO;
                dataGridView3.Rows[i].Cells[0].Value = "Durum(" + i + ")_" + RanO;
                for (int j = 0; j < SonucSayisi; j++)
                {
                    _sonuclar[j] *= OzellikSonuc[i].Durumlar[RanO,j];
                }
            }
            
            //Büyük olanı bul
            int BuyugunIndexi = 0;
            for (int j = 0; j < SonucSayisi; j++)
            {
                _sonuclar[j] *= SonucSayilari[j];
                if (_sonuclar[BuyugunIndexi] < _sonuclar[j])
                {
                    BuyugunIndexi = j;
                }
            }
            label5.Text = "Sonuc_" + BuyugunIndexi;            

            dataGridView3.AutoResizeColumns();     
        }
    }
}
