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
    public partial class DeletePersoane : Form
    {
        public DeletePersoane()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [Persoane] WHERE CNP = '" +txt_cnp.Text+ "' ", conn);
                del.ExecuteNonQuery();
                MessageBox.Show("Stergere realizata cu succes!");
                conn.Close();
               

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
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                string u_name = "SELECT CNP FROM  Persoane";
                SqlDataAdapter sda = new SqlDataAdapter(u_name, conn);
                sda.Fill(ds);
                comboBox1_cnp.DataSource = ds.Tables[0];
                comboBox1_cnp.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading combobox" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p_cnp = comboBox1_cnp.Text;

            try
            {
                conn.Open();
                SqlCommand con = new SqlCommand("SELECT * FROM [Persoane] WHERE  (CNP = '" + p_cnp + "')", conn);
                SqlDataReader reader;
                reader = con.ExecuteReader();
                while (reader.Read())
                {
                    txt_cnp.Text = reader.GetValue(3).ToString();
                    txt_nume.Text = reader.GetValue(1).ToString();
                    txt_prenume.Text = reader.GetValue(2).ToString();
                    txt_sex.Text = reader.GetValue(4).ToString();
                    txt_domiciliu.Text = reader.GetValue(7).ToString();
                    txt_datanasterii.Text = reader.GetValue(5).ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in searching" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeletePersoane_Load(object sender, EventArgs e)
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
            // combobox
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                string u_name = "SELECT CNP FROM  Persoane";
                SqlDataAdapter sda = new SqlDataAdapter(u_name, conn);
                sda.Fill(ds);
                comboBox1_cnp.DataSource = ds.Tables[0];
                comboBox1_cnp.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading combobox" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txt_cnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_datanasterii_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_domiciliu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_sex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_cnp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
