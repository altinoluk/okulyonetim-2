using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class DersGuncelle : Form
    {
        public DersGuncelle()
        {
            InitializeComponent();
        }
        private int okulYonetim = 0;
        public int secilenSatir = 0;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Ders entity = new Models.Ders()
                {
                    Id = secilenSatir,
                    Ad = txtAd.Text,
                    DersRenk = txtRenk.Text,
                    Kredi = Convert.ToInt32(txtKredi.Text),
                    OkulYonetimId = okulYonetim
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

        private void DersGuncelle_Load(object sender, EventArgs e)
        {
            using (ProjeContext context = new ProjeContext())
            {
                var data = context.Ders.SingleOrDefault(x => x.Id == secilenSatir);

                txtAd.Text = data.Ad;
                txtKredi.Text = data.Kredi.ToString();
                txtRenk.Text = data.DersRenk;
                okulYonetim = data.OkulYonetimId;
            }
        }

        private void DersGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            DersListe dersListe = new DersListe();
            dersListe.Show();
            this.Hide();
        }
    }
}
