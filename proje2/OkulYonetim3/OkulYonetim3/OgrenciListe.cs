using System;
using System.Linq;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class OgrenciListe : Form
    {
        public OgrenciListe()
        {
            InitializeComponent();
        }

        public int secilenSatir = 0;

        private void OgrenciListe_Load(object sender, EventArgs e)
        {
            try
            {
                using (ProjeContext context = new ProjeContext())
                {
                    var liste = context.Set<Models.Ogrenci>().ToList();

                    dataGridView1.DataSource = liste;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            secilenSatir = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                using (ProjeContext context = new ProjeContext())
                {
                    var silinecek = context.Ogrenci.SingleOrDefault(x => x.Id == secilenSatir);

                    if (silinecek != null)
                    {
                        context.Ogrenci.Remove(silinecek);
                        context.SaveChanges();
                    }

                    var liste = context.Set<Models.Ogrenci>().ToList();
                    
                    dataGridView1.DataSource = liste;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OgrenciGuncelle form = new OgrenciGuncelle();
            form.secilenSatir = secilenSatir;
            form.Show();
            this.Hide();
        }
    }
}
