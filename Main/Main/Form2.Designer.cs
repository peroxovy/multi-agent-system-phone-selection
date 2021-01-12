namespace Main
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAgentKup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ekran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dotykowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zdjecia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wodoodpornosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DualSim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzywanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 160);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lp,
            this.IDAgentKup,
            this.IDTelefon,
            this.Nazwa,
            this.Ekran,
            this.Dotykowy,
            this.Waga,
            this.Bateria,
            this.Zdjecia,
            this.Wodoodpornosc,
            this.DualSim,
            this.Uzywanie,
            this.Cena});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 369);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kryteria użytkownika:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 400);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Znalezione przez agentów:";
            // 
            // Lp
            // 
            this.Lp.HeaderText = "Lp.";
            this.Lp.Name = "Lp";
            this.Lp.Width = 30;
            // 
            // IDAgentKup
            // 
            this.IDAgentKup.HeaderText = "IDAgentKup";
            this.IDAgentKup.Name = "IDAgentKup";
            this.IDAgentKup.Width = 60;
            // 
            // IDTelefon
            // 
            this.IDTelefon.HeaderText = "ID Telefon";
            this.IDTelefon.Name = "IDTelefon";
            this.IDTelefon.Width = 50;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Width = 70;
            // 
            // Ekran
            // 
            this.Ekran.HeaderText = "Rozmiar Ekranu";
            this.Ekran.Name = "Ekran";
            this.Ekran.Width = 60;
            // 
            // Dotykowy
            // 
            this.Dotykowy.HeaderText = "Dotykowy Ekran";
            this.Dotykowy.Name = "Dotykowy";
            this.Dotykowy.Width = 60;
            // 
            // Waga
            // 
            this.Waga.HeaderText = "Waga";
            this.Waga.Name = "Waga";
            this.Waga.Width = 60;
            // 
            // Bateria
            // 
            this.Bateria.HeaderText = "Praca Baterii";
            this.Bateria.Name = "Bateria";
            this.Bateria.Width = 60;
            // 
            // Zdjecia
            // 
            this.Zdjecia.HeaderText = "Zdjecia";
            this.Zdjecia.Name = "Zdjecia";
            this.Zdjecia.Width = 60;
            // 
            // Wodoodpornosc
            // 
            this.Wodoodpornosc.HeaderText = "Wodoodpornosc";
            this.Wodoodpornosc.Name = "Wodoodpornosc";
            this.Wodoodpornosc.Width = 60;
            // 
            // DualSim
            // 
            this.DualSim.HeaderText = "Dual Sim";
            this.DualSim.Name = "DualSim";
            this.DualSim.Width = 60;
            // 
            // Uzywanie
            // 
            this.Uzywanie.HeaderText = "Uzywanie";
            this.Uzywanie.Name = "Uzywanie";
            this.Uzywanie.Width = 60;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(21, 203);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(184, 23);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Wybierz zaznaczony";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(21, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataSource = typeof(Main.Phone);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 473);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAgentKup;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ekran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dotykowy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zdjecia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wodoodpornosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DualSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzywanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCancel;
    }
}