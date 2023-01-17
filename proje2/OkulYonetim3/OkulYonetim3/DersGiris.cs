using System;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace OkulYonetim3
{
    public partial class DersGiris : Form
    {


        public DersGiris()
        {
            InitializeComponent();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Ders entity = new Models.Ders()
                {
                    Ad = txtAd.Text,
                    Kredi = Convert.ToInt32(txtKredi.Text),
                    OkulYonetimId = Convert.ToInt32(cmbOgretmen.SelectedIndex),
                    DersRenk = cmbRenk.Text
                };

                using (ProjeContext context = new ProjeContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }

                MessageBox.Show("Kayıt başarılı");

                txtAd.Text = "";
                txtKredi.Text = "";
                cmbRenk.Text = "";
                cmbOgretmen.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void DersGiris_Load(object sender, EventArgs e)
        {
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));

            foreach (KnownColor knowColor in colors)
            {
                Color color = Color.FromKnownColor(knowColor);
                cmbRenk.Items.Add(color.Name);
            }

            using (ProjeContext context = new ProjeContext())
            {
                var liste = context.Set<Models.Personel>().ToList();
                cmbOgretmen.DataSource = liste;
                cmbOgretmen.DisplayMember = "AdSoyad";
            }
        }
    }
}
