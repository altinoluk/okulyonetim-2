using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Ogrenci entity = new Models.Ogrenci()
                {
                    AdSoyad = txtAd.Text,
                    Bolum = txtBolum.Text,
                    OgrenciNo = txtOgrenciNo.Text,
                    DTarih = dateTimePicker1.Value,
                    KayitTarih = DateTime.Now
                };

                using (ProjeContext context = new ProjeContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }

                MessageBox.Show("Kayıt başarılı");

                txtAd.Text = "";
                txtBolum.Text = "";
                txtOgrenciNo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
