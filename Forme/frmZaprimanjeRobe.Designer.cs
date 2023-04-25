
namespace OnlineFanShop
{
    partial class frmZaprimanjeRobe
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
            this.dgvStanjeSkladista = new System.Windows.Forms.DataGridView();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.cmbFranšiza = new System.Windows.Forms.ComboBox();
            this.cmbVeličina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDatumPrimke = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPrimku = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtImeDobavljača = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSifraPrimke = new System.Windows.Forms.ComboBox();
            this.cmbNazivProizvoda = new System.Windows.Forms.ComboBox();
            this.btnDodajRobu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanjeSkladista
            // 
            this.dgvStanjeSkladista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStanjeSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanjeSkladista.Location = new System.Drawing.Point(5, 147);
            this.dgvStanjeSkladista.Name = "dgvStanjeSkladista";
            this.dgvStanjeSkladista.Size = new System.Drawing.Size(425, 444);
            this.dgvStanjeSkladista.TabIndex = 26;
            this.dgvStanjeSkladista.TabStop = false;
            this.dgvStanjeSkladista.SelectionChanged += new System.EventHandler(this.dgvStanjeSkladista_SelectionChanged);
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Location = new System.Drawing.Point(85, 20);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.Size = new System.Drawing.Size(177, 23);
            this.txtNazivProizvoda.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajProizvod);
            this.groupBox2.Controls.Add(this.cmbFranšiza);
            this.groupBox2.Controls.Add(this.cmbVeličina);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbVrsta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNazivProizvoda);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(726, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 205);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje novog proizvoda";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(20, 159);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(242, 31);
            this.btnDodajProizvod.TabIndex = 12;
            this.btnDodajProizvod.Text = "Dodaj novi proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // cmbFranšiza
            // 
            this.cmbFranšiza.FormattingEnabled = true;
            this.cmbFranšiza.Location = new System.Drawing.Point(85, 123);
            this.cmbFranšiza.Name = "cmbFranšiza";
            this.cmbFranšiza.Size = new System.Drawing.Size(177, 24);
            this.cmbFranšiza.TabIndex = 11;
            // 
            // cmbVeličina
            // 
            this.cmbVeličina.FormattingEnabled = true;
            this.cmbVeličina.Location = new System.Drawing.Point(85, 89);
            this.cmbVeličina.Name = "cmbVeličina";
            this.cmbVeličina.Size = new System.Drawing.Size(177, 24);
            this.cmbVeličina.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Franšiza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Veličina:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(85, 54);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(177, 24);
            this.cmbVrsta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(328, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Fan Shop";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.btnIzvjestaj);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-3, -7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 125);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.Location = new System.Drawing.Point(385, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "Zaprimanje robe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(2, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Stanje skladišta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDatumPrimke);
            this.groupBox3.Controls.Add(this.btnDodajPrimku);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtImeDobavljača);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(440, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 205);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodavanje nove primke";
            // 
            // dtpDatumPrimke
            // 
            this.dtpDatumPrimke.Location = new System.Drawing.Point(20, 51);
            this.dtpDatumPrimke.Name = "dtpDatumPrimke";
            this.dtpDatumPrimke.Size = new System.Drawing.Size(242, 23);
            this.dtpDatumPrimke.TabIndex = 13;
            // 
            // btnDodajPrimku
            // 
            this.btnDodajPrimku.Location = new System.Drawing.Point(20, 159);
            this.btnDodajPrimku.Name = "btnDodajPrimku";
            this.btnDodajPrimku.Size = new System.Drawing.Size(242, 31);
            this.btnDodajPrimku.TabIndex = 12;
            this.btnDodajPrimku.Text = "Dodaj novu primku";
            this.btnDodajPrimku.UseVisualStyleBackColor = true;
            this.btnDodajPrimku.Click += new System.EventHandler(this.btnDodajPrimku_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ime dobavljača:";
            // 
            // txtImeDobavljača
            // 
            this.txtImeDobavljača.Location = new System.Drawing.Point(20, 123);
            this.txtImeDobavljača.Name = "txtImeDobavljača";
            this.txtImeDobavljača.Size = new System.Drawing.Size(242, 23);
            this.txtImeDobavljača.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Datum:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudKolicina);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cmbSifraPrimke);
            this.groupBox4.Controls.Add(this.cmbNazivProizvoda);
            this.groupBox4.Controls.Add(this.btnDodajRobu);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(440, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 239);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodavanje robe u skladište";
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(20, 151);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(242, 23);
            this.nudKolicina.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Količina:";
            // 
            // cmbSifraPrimke
            // 
            this.cmbSifraPrimke.FormattingEnabled = true;
            this.cmbSifraPrimke.Location = new System.Drawing.Point(20, 92);
            this.cmbSifraPrimke.Name = "cmbSifraPrimke";
            this.cmbSifraPrimke.Size = new System.Drawing.Size(242, 24);
            this.cmbSifraPrimke.TabIndex = 14;
            // 
            // cmbNazivProizvoda
            // 
            this.cmbNazivProizvoda.FormattingEnabled = true;
            this.cmbNazivProizvoda.Location = new System.Drawing.Point(20, 43);
            this.cmbNazivProizvoda.Name = "cmbNazivProizvoda";
            this.cmbNazivProizvoda.Size = new System.Drawing.Size(242, 24);
            this.cmbNazivProizvoda.TabIndex = 13;
            // 
            // btnDodajRobu
            // 
            this.btnDodajRobu.Location = new System.Drawing.Point(20, 191);
            this.btnDodajRobu.Name = "btnDodajRobu";
            this.btnDodajRobu.Size = new System.Drawing.Size(242, 31);
            this.btnDodajRobu.TabIndex = 12;
            this.btnDodajRobu.Text = "Dodaj robu u skladište";
            this.btnDodajRobu.UseVisualStyleBackColor = true;
            this.btnDodajRobu.Click += new System.EventHandler(this.btnDodajRobu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sifra primke:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Naziv proizvoda:";
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(811, 444);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(131, 46);
            this.btnDetalji.TabIndex = 36;
            this.btnDetalji.Text = "Detalji zaprimanja";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(14, 87);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(124, 26);
            this.btnIzvjestaj.TabIndex = 6;
            this.btnIzvjestaj.Text = "Generiraj izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // frmZaprimanjeRobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 595);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStanjeSkladista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "80");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MaximizeBox = false;
            this.Name = "frmZaprimanjeRobe";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zaprimanje robe";
            this.Load += new System.EventHandler(this.frmZaprimanjeRobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeSkladista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStanjeSkladista;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.ComboBox cmbFranšiza;
        private System.Windows.Forms.ComboBox cmbVeličina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDatumPrimke;
        private System.Windows.Forms.Button btnDodajPrimku;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtImeDobavljača;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSifraPrimke;
        private System.Windows.Forms.ComboBox cmbNazivProizvoda;
        private System.Windows.Forms.Button btnDodajRobu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}