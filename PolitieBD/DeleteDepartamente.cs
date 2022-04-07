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
    public partial class DeleteDepartamente : Form
    {
        public DeleteDepartamente()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");

        private void DeleteDepartamente_Load(object sender, EventArgs e)
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
            // combobox
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                string u_name = "SELECT Nume FROM  Departamente";
                SqlDataAdapter sda = new SqlDataAdapter(u_name, conn);
                sda.Fill(ds);
                comboBox1_nume.DataSource = ds.Tables[0];
                comboBox1_nume.DisplayMember = ds.Tables[0].Columns[0].ToString();
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
            string p_nume = comboBox1_nume.Text;

            try
            {
                conn.Open();
                SqlCommand con = new SqlCommand("SELECT * FROM [Departamente] WHERE  (Nume = '" + p_nume + "')", conn);
                SqlDataReader reader;
                reader = con.ExecuteReader();
                while (reader.Read())
                {
                    
                    txt_nume.Text = reader.GetValue(1).ToString();
                    txt_pozitionare.Text = reader.GetValue(2).ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [Departamente] WHERE Nume = '" + txt_nume.Text + "' ", conn);
                del.ExecuteNonQuery();
                MessageBox.Show("Stergere realizata cu succes!");
                conn.Close();


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

            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                string u_name = "SELECT Nume FROM  Departamente";
                SqlDataAdapter sda = new SqlDataAdapter(u_name, conn);
                sda.Fill(ds);
                comboBox1_nume.DataSource = ds.Tables[0];
                comboBox1_nume.DisplayMember = ds.Tables[0].Columns[0].ToString();
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
    }
}
