using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using PAB4.Models;
using Dapper;

namespace PAB4
{
    public partial class Form1 : Form
    {
        string kod, adres, miejscowosc, wojewodztwo, powiat, uwagi;
        UserControl2 userControl2;

        public Form1()
        {
            InitializeComponent();
            GridRefresh();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        public void GridRefresh()
        {
            using (var kontekst = new PabContext())
            {
                var dane = kontekst.KodyPocztowes.ToList();
                dataGridView1.DataSource = dane;
            }
        }

        public void TextboxRead()
        {
            kod = textbox_kod.Text;
            adres = textbox_adres.Text;
            miejscowosc = textbox_miejscowosc.Text;
            wojewodztwo = textbox_wojewodztwo.Text;
            powiat = textbox_powiat.Text;
            uwagi = textbox_uwagi.Text;
        }

        private async void button3_Click_1(object sender, EventArgs e)
        {
            TextboxRead();

            using (SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=PAB; Integrated Security=True; TrustServerCertificate=True;"))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT * FROM Kody_Pocztowe";

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    DataView dataView = dataTable.DefaultView;
                    dataView.RowFilter = $"Kod_Pocztowy LIKE '%{kod}%' AND Adres LIKE '%{adres}%' AND Miejscowosc LIKE '%{miejscowosc}%' AND Wojewodztwo LIKE '%{wojewodztwo}%' AND Powiat LIKE '%{powiat}%' AND Uwagi LIKE '%{uwagi}%'";

                    dataGridView1.DataSource = dataView;
                }
            }
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            TextboxRead();

            using (var kontekst = new PabContext())
            {
                var dane = await kontekst.KodyPocztowes.Where(kod => kod.KodPocztowy.Contains(this.kod) && kod.Adres.Contains(adres) && kod.Miejscowosc.Contains(miejscowosc) && kod.Wojewodztwo.Contains(wojewodztwo) && kod.Powiat.Contains(powiat) && kod.Uwagi.Contains(uwagi)).ToListAsync();
                dataGridView1.DataSource = dane;
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            TextboxRead();

            using (SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=PAB; Integrated Security=True; TrustServerCertificate=True;"))
            {
                await connection.OpenAsync();
                var dane = await connection.QueryAsync
                    ($"SELECT * FROM Kody_Pocztowe WHERE Kod_Pocztowy LIKE '%{kod}%' AND Adres LIKE '%{adres}%' AND Miejscowosc LIKE '%{miejscowosc}%' AND Wojewodztwo LIKE '%{wojewodztwo}%' AND Powiat LIKE '%{powiat}%' AND Uwagi LIKE '%{uwagi}%'");
                dataGridView1.DataSource = dane;

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idKodu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                using (var kontekst = new PabContext())
                {
                    var lokalizacje = kontekst.Lokalizacjes.Where(l => l.IdKoduPocztowego == idKodu).ToList();
                    userControl15.dataGridView1.DataSource = lokalizacje;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                errorLabel.Text = "";
                userControl2 = new UserControl2();
                Controls.Add(userControl2);
                userControl2.editButton.Click += new EventHandler(EditButton_Click);
                userControl2.deleteButton.Click += new EventHandler(DeleteButton_Click);
                errorLabel.Text = "";
            }
            else errorLabel.Text = "wybierz jeden wpis";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idKodu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                using (var kontekst = new PabContext())
                {
                    var kodPocztowy = kontekst.KodyPocztowes.SingleOrDefault(k => k.Id == idKodu);

                    kodPocztowy.KodPocztowy = userControl2.textbox_kod.Text;
                    kodPocztowy.Adres = userControl2.textbox_adres.Text;
                    kodPocztowy.Miejscowosc = userControl2.textbox_miejscowosc.Text;
                    kodPocztowy.Wojewodztwo = userControl2.textbox_wojewodztwo.Text;
                    kodPocztowy.Powiat = userControl2.textbox_powiat.Text;
                    kodPocztowy.Uwagi = userControl2.textbox_uwagi.Text;

                    kontekst.SaveChanges();
                    
                    errorLabel.Text = "Pomyœlnie zaktualizowano dane!";
                    GridRefresh();
                }
            }
            catch(Exception ex)
            {
                errorLabel.Text = "B³¹d: "+ex;
            }

            Controls.Remove(userControl2);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idKodu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                using (var kontekst = new PabContext())
                {
                    kontekst.KodyPocztowes.Remove(kontekst.KodyPocztowes.SingleOrDefault(k => k.Id == idKodu));
                    kontekst.SaveChanges();
                    errorLabel.Text = "Pomyœlnie usuniêto wpis!";
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = "B³¹d: "+ex;
            }

            Controls.Remove(userControl2);
        }
    }
}