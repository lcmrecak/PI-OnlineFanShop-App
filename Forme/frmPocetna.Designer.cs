
namespace OnlineFanShop
{
    partial class frmPocetna
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.dgvPonuda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.cmbFranšiza = new System.Windows.Forms.ComboBox();
            this.cmbVeličina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijenaMax = new System.Windows.Forms.TextBox();
            this.txtCijenaMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnDodajUKosaricu = new System.Windows.Forms.Button();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.btnResetiraj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.helpProviderPocetnaGost = new System.Windows.Forms.HelpProvider();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(1255, 63);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(91, 32);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.btnRegistracija);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrijava);
            this.groupBox1.Controls.Add(this.btnKosarica);
            this.groupBox1.Location = new System.Drawing.Point(-4, -9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1365, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(17, 23);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(115, 32);
            this.btnRegistracija.TabIndex = 2;
            this.btnRegistracija.Text = "Registriraj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1255, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(437, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Fan Shop";
            // 
            // btnKosarica
            // 
            this.btnKosarica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKosarica.Location = new System.Drawing.Point(543, 98);
            this.btnKosarica.Margin = new System.Windows.Forms.Padding(4);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(200, 43);
            this.btnKosarica.TabIndex = 0;
            this.btnKosarica.Text = "Kosarica";
            this.btnKosarica.UseVisualStyleBackColor = true;
            this.btnKosarica.Click += new System.EventHandler(this.btnKosarica_Click);
            // 
            // dgvPonuda
            // 
            this.dgvPonuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPonuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonuda.Location = new System.Drawing.Point(7, 207);
            this.dgvPonuda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPonuda.Name = "dgvPonuda";
            this.dgvPonuda.RowHeadersWidth = 51;
            this.dgvPonuda.Size = new System.Drawing.Size(941, 521);
            this.dgvPonuda.TabIndex = 3;
            this.dgvPonuda.SelectionChanged += new System.EventHandler(this.dgvPonuda_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(629, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sortiranje:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltriraj);
            this.groupBox2.Controls.Add(this.cmbFranšiza);
            this.groupBox2.Controls.Add(this.cmbVeličina);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbVrsta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCijenaMax);
            this.groupBox2.Controls.Add(this.txtCijenaMin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(968, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(373, 252);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtriranje";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(27, 202);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(323, 38);
            this.btnFiltriraj.TabIndex = 12;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // cmbFranšiza
            // 
            this.cmbFranšiza.FormattingEnabled = true;
            this.cmbFranšiza.Location = new System.Drawing.Point(113, 158);
            this.cmbFranšiza.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFranšiza.Name = "cmbFranšiza";
            this.cmbFranšiza.Size = new System.Drawing.Size(235, 28);
            this.cmbFranšiza.TabIndex = 11;
            // 
            // cmbVeličina
            // 
            this.cmbVeličina.FormattingEnabled = true;
            this.cmbVeličina.Location = new System.Drawing.Point(113, 116);
            this.cmbVeličina.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVeličina.Name = "cmbVeličina";
            this.cmbVeličina.Size = new System.Drawing.Size(235, 28);
            this.cmbVeličina.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Franšiza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Veličina:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(113, 73);
            this.cmbVrsta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(235, 28);
            this.cmbVrsta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // txtCijenaMax
            // 
            this.txtCijenaMax.Location = new System.Drawing.Point(245, 31);
            this.txtCijenaMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijenaMax.Name = "txtCijenaMax";
            this.txtCijenaMax.Size = new System.Drawing.Size(103, 26);
            this.txtCijenaMax.TabIndex = 2;
            // 
            // txtCijenaMin
            // 
            this.txtCijenaMin.Location = new System.Drawing.Point(113, 31);
            this.txtCijenaMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijenaMin.Name = "txtCijenaMin";
            this.txtCijenaMin.Size = new System.Drawing.Size(103, 26);
            this.txtCijenaMin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cijena:";
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(735, 161);
            this.cmbSortiranje.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(212, 24);
            this.cmbSortiranje.TabIndex = 5;
            this.cmbSortiranje.SelectedIndexChanged += new System.EventHandler(this.cmbSortiranje_SelectedIndexChanged);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPretrazi.Location = new System.Drawing.Point(280, 161);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(288, 29);
            this.txtPretrazi.TabIndex = 9;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnDodajUKosaricu
            // 
            this.btnDodajUKosaricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajUKosaricu.Location = new System.Drawing.Point(968, 513);
            this.btnDodajUKosaricu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajUKosaricu.Name = "btnDodajUKosaricu";
            this.btnDodajUKosaricu.Size = new System.Drawing.Size(373, 38);
            this.btnDodajUKosaricu.TabIndex = 10;
            this.btnDodajUKosaricu.Text = "Dodaj u košaricu";
            this.btnDodajUKosaricu.UseVisualStyleBackColor = true;
            this.btnDodajUKosaricu.Click += new System.EventHandler(this.btnDodajUKosaricu_Click);
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(968, 468);
            this.btnPrikaziDetalje.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(373, 38);
            this.btnPrikaziDetalje.TabIndex = 12;
            this.btnPrikaziDetalje.Text = "Prikaži detalje o proizvodu";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResetiraj.Location = new System.Drawing.Point(968, 689);
            this.btnResetiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(373, 38);
            this.btnResetiraj.TabIndex = 13;
            this.btnResetiraj.Text = "Resetiraj prikaz ponude";
            this.btnResetiraj.UseVisualStyleBackColor = true;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(16, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pretraži po nazivu proizvoda:";
            // 
            // helpProviderPocetnaGost
            // 
            this.helpProviderPocetnaGost.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(1032, 425);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 22);
            this.numKolicina.TabIndex = 33;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(971, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Količina:";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1357, 732);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.btnDodajUKosaricu);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPonuda);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProviderPocetnaGost.SetHelpKeyword(this, "30");
            this.helpProviderPocetnaGost.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPocetna";
            this.helpProviderPocetnaGost.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Fan Shop";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPonuda;
        private System.Windows.Forms.Button btnKosarica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox cmbFranšiza;
        private System.Windows.Forms.ComboBox cmbVeličina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijenaMax;
        private System.Windows.Forms.TextBox txtCijenaMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnDodajUKosaricu;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.Button btnResetiraj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HelpProvider helpProviderPocetnaGost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label9;
    }
}