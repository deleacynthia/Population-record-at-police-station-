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
    public partial class InterogariComplexe : Form
    {
        public InterogariComplexe()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BCT8U3A\SQLEXPRESS;Initial Catalog=PolitieBD;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select year(P.DataIntocmirii) as AN, count(PlangereID) as NUMAR_DE_PLANGERI from Plangeri P group by year(P.DataIntocmirii) having count(P.PlangereID) = (select top 1 count(P1.DataIntocmirii) from Plangeri P1 group by year(P1.DataIntocmirii) order by count(P1.DataIntocmirii)desc) order by count (P.DataIntocmirii) desc ";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select P.Motiv, year(P.DataIntocmirii) as An from Plangeri P join Angajati A on P.AngajatID = A.AngajatID where A.AngajatID   in (select(A2.AngajatID) from Angajati A2 join Plangeri P2  on P2.AngajatID = A2.AngajatID where A2.AngajatID = 200) order by year(P.DataIntocmirii) desc ";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select P.Nume, P.Prenume from Persoane P where P.PersoanaID not in ( select P1.PersoanaID from Persoane P1 inner join Caziere C on C.PersoanaID = P1.PersoanaID)";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string load = "select A.Motiv, A.[Tip/Incadrare], A.Suma from Amenzi A where A.Suma in (select distinct top 3 A1.Suma from Amenzi A1 order by Suma desc) order by suma desc";
            SqlDataAdapter da = new SqlDataAdapter(load, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
