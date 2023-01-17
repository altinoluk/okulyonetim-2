using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Personel entity = new Models.Personel()
                {
                    AdSoyad = txtAd.Text,
                    Gorevi = txtGorev.Text,
                    YonetimTip = cmbYonetimTip.Text
                };

                using (ProjeContext context = new ProjeContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }

                MessageBox.Show("Kayıt başarılı");

                txtAd.Text = "";
                txtGorev.Text = "";
                cmbYonetimTip.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
