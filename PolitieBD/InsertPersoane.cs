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
    public partial class InsertPersoane : Form
    {
        
        public InsertPersoane()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertPersoane_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string load = "SELECT * FROM Persoane";
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

        private void insert_button_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                string query = "INSERT INTO Persoane (PersoanaID, Nume, Prenume, CNP, Sex, DataNasterii, LoculNasterii, Domiciliu, Telefon) VALUES ('" + txt_persoanaid.Text + "' ,'" + txt_nume.Text + "' , '"+txt_prenume.Text + "', '" + txt_cnp.Text + "' , '" + txt_sex.Text + "','" + txt_datanasterii.Text + "', '" + txt_loculnasterii.Text + "','" + txt_domociliu.Text + "','" + txt_telefon.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Inserare realizata cu succes!");

                string con = "Data Source=DESKTOP-BCT8U3A\\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(con))
                {

                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Persoane", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dtbl;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void afisare_button_Click(object sender, EventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_persoanaid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
