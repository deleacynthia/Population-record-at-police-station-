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
    public partial class InsertDepartamente : Form
    {
        public InsertDepartamente()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Departamente (DepartamentID, Nume, Pozitionare) VALUES ('" + txt_departamid.Text+ "' ,'" + txt_numedep.Text + "' ,'" + txt_pozitionare.Text + "' )";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Inserare realizata cu succes!");

                string con = "Data Source=DESKTOP-BCT8U3A\\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(con))
                {
                   
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Departamente", sqlCon);
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

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void InsertDepartamente_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string load = "SELECT * FROM Departamente";
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
    }
}
