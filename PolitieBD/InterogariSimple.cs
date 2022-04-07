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
    public partial class InterogariSimple : Form
    {
        public InterogariSimple()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");

        private void InterogariSimple_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataSet ds = new DataSet();
            string nume = "SELECT Nume FROM Departamente";
            SqlDataAdapter da = new SqlDataAdapter(nume, conn);
            da.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = ds.Tables[0].Columns[0].ToString();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataSet ds = new DataSet();
            string nume = "SELECT nume FROM Angajati";
            SqlDataAdapter da = new SqlDataAdapter(nume, conn);
            da.Fill(ds);

            comboBox1.DisplayMember = ds.Tables[0].Columns[0].ToString();
            string load = "select A.Nume,A.Prenume from Angajati A join Departamente D on A.DepartamentID = D.DepartamentID where D.Nume = '" + comboBox1.Text + "'  ";
            SqlDataAdapter y = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            y.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select distinct P.Nume, P.Prenume from Persoane P join Persoane_amenzi PA on P.PersoanaID = PA.PersoanaID join Amenzi A on A.AmendaID = PA.AmendaID where A.Motiv = 'Depasirea limitei de viteza'";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select D.Nume, count(AngajatID) as NumarAngajati from Departamente D join Angajati A on D.DepartamentID = A.DepartamentID group by D.Nume";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select distinct A.Nume, A.Prenume from Angajati A join Plangeri P on A.AngajatID = P.AngajatID join Amenzi AM on A.AngajatID = AM.AngajatID";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select P.Nume, P.Prenume from Persoane P join Caziere C on P.PersoanaID = C.PersoanaID join Infractiuni_caziere IC on C.CazierID = IC.CazierID join Infractiuni I on IC.InfractiuneID = I.InfractiuneID where cast(I.Pedeapsa as int) > 2";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select distinct top 2  A.Salariu, A.Nume ,A.Prenume from Angajati A join Amenzi AM on A.AngajatID = AM.AngajatID where AM.[Tip/Incadrare] = 'Contraventie' order by A.Salariu desc";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
