using System;
using System.Linq;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class DersListe : Form
    {
        public DersListe()
        {
            InitializeComponent();
        }

        public int secilenSatir = 0;

        private void DersListe_Load(object sender, EventArgs e)
        {
            try
            {
                using (ProjeContext context = new ProjeContext())
                {
                    var liste = context.Set<Models.Ders>().ToList();

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

        private void button1_Click(object sender, EventArgs e)
        {
            DersGuncelle form = new DersGuncelle();
            form.secilenSatir = secilenSatir;
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                using (ProjeContext context = new ProjeContext())
                {
                    var silinecek = context.Ders.SingleOrDefault(x => x.Id == secilenSatir);

                    if (silinecek != null)
                    {
                        context.Ders.Remove(silinecek);
                        context.SaveChanges();
                    }

                    var liste = context.Set<Models.Ders>().ToList();

                    dataGridView1.DataSource = liste;
                }
            }
        }
    }
}
