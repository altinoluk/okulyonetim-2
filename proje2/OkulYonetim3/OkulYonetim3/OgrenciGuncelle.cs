using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class OgrenciGuncelle : Form
    {
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }

        Models.Ogrenci data = new Models.Ogrenci();
        public int secilenSatir = 0;

        private void OgrenciGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            OgrenciListe form = new OgrenciListe();
            form.Show();
            this.Hide();
        }

        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            using (ProjeContext context = new ProjeContext())
            {
                data = context.Ogrenci.SingleOrDefault(x => x.Id == secilenSatir);

                txtAd.Text = data.AdSoyad;
                txtOgrenciNo.Text = data.OgrenciNo;
                txtBolum.Text = data.Bolum;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Ogrenci entity = new Models.Ogrenci()
                {
                    Id = secilenSatir,
                    AdSoyad = txtAd.Text,
                    Bolum = txtBolum.Text,
                    OgrenciNo = txtOgrenciNo.Text,
                    DTarih = data.DTarih,
                    KayitTarih = data.KayitTarih
                };

                using (ProjeContext context = new ProjeContext())
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }

                MessageBox.Show("Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
