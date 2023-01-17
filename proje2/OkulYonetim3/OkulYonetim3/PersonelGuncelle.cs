using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        public int secilenSatir = 0;

        private void PersonelGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonelListe form = new PersonelListe();
            form.Show();
            this.Hide();
        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            using (ProjeContext context = new ProjeContext())
            {
                var data = context.Personel.SingleOrDefault(x => x.Id == secilenSatir);

                txtAd.Text = data.AdSoyad;
                txtGorev.Text = data.Gorevi;
                cmbYonetimTip.Text = data.YonetimTip;
              
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Personel entity = new Models.Personel()
                {
                    Id = secilenSatir,
                    AdSoyad = txtAd.Text,
                    Gorevi = txtGorev.Text,
                    YonetimTip = cmbYonetimTip.Text
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
