using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class OgrenciDersListe : Form
    {
        public OgrenciDersListe()
        {
            InitializeComponent();
        }

        public int secilenSatir = 0;

        private void OgrenciDersListe_Load(object sender, EventArgs e)
        {
            try
            {
                using (ProjeContext context = new ProjeContext())
                {
                    var liste = (from s in context.OgrenciDers
                                 join ogr in context.Ogrenci on s.OgrenciId equals ogr.Id
                                 join d in context.Ders on s.DersId equals d.Id
                                 select new { Ders = d.Ad, Ogrenci = ogr.AdSoyad } ).ToList();

                    dataGridView1.DataSource = liste;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
