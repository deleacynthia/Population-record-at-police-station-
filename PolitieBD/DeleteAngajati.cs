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
    public partial class DeleteAngajati : Form
    {
        public DeleteAngajati()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");
        private void DeleteAngajati_Load(object sender, EventArgs e)
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
            // combobox
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                string u_name = "SELECT CNP FROM  Angajati";
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
                SqlCommand con = new SqlCommand("SELECT * FROM [Angajati] WHERE  (CNP = '" + p_cnp + "')", conn);
                SqlDataReader reader;
                reader = con.ExecuteReader();
                while (reader.Read())
                {
                    txt_cnp.Text = reader.GetValue(4).ToString();
                    txt_nume.Text = reader.GetValue(2).ToString();
                    txt_prenume.Text = reader.GetValue(3).ToString();
                    txt_sex.Text = reader.GetValue(5).ToString();
                    txt_anivechime.Text = reader.GetValue(6).ToString();
                    txt_salariu.Text = reader.GetValue(7).ToString();
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
                SqlCommand del = new SqlCommand("DELETE FROM [Angajati] WHERE CNP = '" + txt_cnp.Text + "' ", conn);
                del.ExecuteNonQuery();
                MessageBox.Show("Stergere realizata cu succes!");
                conn.Close();


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

            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                string u_name = "SELECT CNP FROM  Angajati";
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
    }
}
