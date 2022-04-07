using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolitieBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void persoaneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openChildForm(new InsertPersoane());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new InsertAngajati());
        }

        private void insertToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new InsertDepartamente());
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openChildForm(new UpdatePersoane());
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateAngajati());
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateDepartamente());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new DeletePersoane());
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteAngajati());
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteDepartamente());
        }

        private void sIMPLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new InterogariSimple());
        }

        private void cOMPLEXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new InterogariComplexe());
        }
    }
}
