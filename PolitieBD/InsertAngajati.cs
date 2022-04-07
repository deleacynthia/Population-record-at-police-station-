using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;

namespace PolitieBD
{
    public partial class InsertAngajati : Form
    {
        public InsertAngajati()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_persoanaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_domociliu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_loculnasterii_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_datanasterii_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void InsertAngajati_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string load = "SELECT * FROM Angajati";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Angajati (AngajatID, DepartamentID, Nume, Prenume, CNP, Sex, AniVechime, Salariu) VALUES ('" + txt_angajatid.Text + "' ,'" + txt_departamentid.Text + "' ,'" + txt_numeangajat.Text + "' , '" + txt_prenumeangajat.Text + "', '" + txt_cnp.Text + "' , '" + txt_sex.Text + "','" + txt_anivechime.Text + "', '" + txt_salariu.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Inserare realizata cu succes!");

                string con = "Data Source=DESKTOP-BCT8U3A\\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(con))
                {

                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Angajati", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dtbl;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
