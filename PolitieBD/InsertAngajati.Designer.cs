namespace PolitieBD
{
    partial class InsertAngajati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_angajatid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_salariu = new System.Windows.Forms.TextBox();
            this.txt_anivechime = new System.Windows.Forms.TextBox();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.txt_prenumeangajat = new System.Windows.Forms.TextBox();
            this.txt_cnp = new System.Windows.Forms.TextBox();
            this.txt_numeangajat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_departamentid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_angajatid
            // 
            this.txt_angajatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_angajatid.Location = new System.Drawing.Point(195, 90);
            this.txt_angajatid.Name = "txt_angajatid";
            this.txt_angajatid.Size = new System.Drawing.Size(155, 26);
            this.txt_angajatid.TabIndex = 37;
            this.txt_angajatid.TextChanged += new System.EventHandler(this.txt_persoanaid_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Angajat ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_salariu
            // 
            this.txt_salariu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salariu.Location = new System.Drawing.Point(195, 437);
            this.txt_salariu.Name = "txt_salariu";
            this.txt_salariu.Size = new System.Drawing.Size(155, 26);
            this.txt_salariu.TabIndex = 33;
            this.txt_salariu.TextChanged += new System.EventHandler(this.txt_loculnasterii_TextChanged);
            // 
            // txt_anivechime
            // 
            this.txt_anivechime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_anivechime.Location = new System.Drawing.Point(195, 385);
            this.txt_anivechime.Name = "txt_anivechime";
            this.txt_anivechime.Size = new System.Drawing.Size(155, 26);
            this.txt_anivechime.TabIndex = 32;
            this.txt_anivechime.TextChanged += new System.EventHandler(this.txt_datanasterii_TextChanged);
            // 
            // txt_sex
            // 
            this.txt_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sex.Location = new System.Drawing.Point(195, 336);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(155, 26);
            this.txt_sex.TabIndex = 31;
            this.txt_sex.TextChanged += new System.EventHandler(this.txt_sex_TextChanged);
            // 
            // txt_prenumeangajat
            // 
            this.txt_prenumeangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenumeangajat.Location = new System.Drawing.Point(195, 240);
            this.txt_prenumeangajat.Name = "txt_prenumeangajat";
            this.txt_prenumeangajat.Size = new System.Drawing.Size(155, 26);
            this.txt_prenumeangajat.TabIndex = 30;
            this.txt_prenumeangajat.TextChanged += new System.EventHandler(this.txt_prenume_TextChanged);
            // 
            // txt_cnp
            // 
            this.txt_cnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnp.Location = new System.Drawing.Point(195, 292);
            this.txt_cnp.Name = "txt_cnp";
            this.txt_cnp.Size = new System.Drawing.Size(155, 26);
            this.txt_cnp.TabIndex = 29;
            this.txt_cnp.TextChanged += new System.EventHandler(this.txt_cnp_TextChanged);
            // 
            // txt_numeangajat
            // 
            this.txt_numeangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeangajat.Location = new System.Drawing.Point(195, 188);
            this.txt_numeangajat.Name = "txt_numeangajat";
            this.txt_numeangajat.Size = new System.Drawing.Size(155, 26);
            this.txt_numeangajat.TabIndex = 28;
            this.txt_numeangajat.TextChanged += new System.EventHandler(this.txt_nume_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Salariu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ani Vechime";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sex";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "CNP";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Prenume";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nume";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Departament ID";
            // 
            // txt_departamentid
            // 
            this.txt_departamentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamentid.Location = new System.Drawing.Point(195, 134);
            this.txt_departamentid.Name = "txt_departamentid";
            this.txt_departamentid.Size = new System.Drawing.Size(155, 26);
            this.txt_departamentid.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(113, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 40;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(892, 515);
            this.dataGridView1.TabIndex = 41;
            // 
            // InsertAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1336, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_departamentid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_angajatid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_salariu);
            this.Controls.Add(this.txt_anivechime);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.txt_prenumeangajat);
            this.Controls.Add(this.txt_cnp);
            this.Controls.Add(this.txt_numeangajat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "InsertAngajati";
            this.Text = "InsertAngajati";
            this.Load += new System.EventHandler(this.InsertAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_angajatid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_salariu;
        private System.Windows.Forms.TextBox txt_anivechime;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.TextBox txt_prenumeangajat;
        private System.Windows.Forms.TextBox txt_cnp;
        private System.Windows.Forms.TextBox txt_numeangajat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_departamentid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}