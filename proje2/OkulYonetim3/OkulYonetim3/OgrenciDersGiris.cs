using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class OgrenciDersGiris : Form
    {
        public OgrenciDersGiris()
        {
            InitializeComponent();
        }

        private void OgrenciDersGiris_Load(object sender, EventArgs e)
        {
            using (ProjeContext context = new ProjeContext())
            {
                var liste1 = context.Set<Models.Ders>().ToList();
                cmbDers.DataSource = liste1;
                cmbDers.DisplayMember = "Ad";
                cmbDers.ValueMember = "Id";

                var liste2 = context.Set<Models.Ogrenci>().ToList();
                cmbOgrenci.DataSource = liste2;
                cmbOgrenci.DisplayMember = "AdSoyad";
                cmbOgrenci.ValueMember = "Id";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                Models.OgrenciDers entity = new Models.OgrenciDers()
                {
                    DersId = Convert.ToInt32(cmbDers.SelectedValue.ToString()),
                    OgrenciId = Convert.ToInt32(cmbOgrenci.SelectedValue.ToString())
                };

                using (ProjeContext context = new ProjeContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }

                MessageBox.Show("Kayıt başarılı");

                cmbOgrenci.Text = "";
                cmbDers.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
