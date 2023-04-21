using PAB4.Models;

namespace PAB4
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        public void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                string kolumna = dataGridView1.Columns[e.ColumnIndex].Name;
                string wartosc = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                using (var kontekst = new PabContext())
                {
                    var lokalizajca = kontekst.Lokalizacjes.FirstOrDefault(l => l.Id == id);
                    if (lokalizajca != null)
                    {
                        switch (kolumna)
                        {
                            case "Nazwa":
                                lokalizajca.Nazwa = wartosc;
                                break;

                            case "Opis":
                                lokalizajca.Opis = wartosc;
                                break;

                            case "ID_kodu_pocztowego":
                                lokalizajca.IdKoduPocztowego = int.Parse(wartosc);
                                break;
                        }
                        kontekst.SaveChanges();
                    }
                }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
