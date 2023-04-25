
namespace OnlineFanShop.Forme
{
    partial class frmUpravljanjePonudom
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
            this.labelNaslovPopisa = new System.Windows.Forms.Label();
            this.dgvPonuda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.btnDodajPonudu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNazivProizvoda = new System.Windows.Forms.ComboBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaslovPopisa
            // 
            this.labelNaslovPopisa.AutoSize = true;
            this.labelNaslovPopisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslovPopisa.Location = new System.Drawing.Point(388, 9);
            this.labelNaslovPopisa.Name = "labelNaslovPopisa";
            this.labelNaslovPopisa.Size = new System.Drawing.Size(190, 32);
            this.labelNaslovPopisa.TabIndex = 0;
            this.labelNaslovPopisa.Text = "Popis ponude";
            // 
            // dgvPonuda
            // 
            this.dgvPonuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPonuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonuda.Location = new System.Drawing.Point(12, 62);
            this.dgvPonuda.Name = "dgvPonuda";
            this.dgvPonuda.RowHeadersWidth = 51;
            this.dgvPonuda.RowTemplate.Height = 24;
            this.dgvPonuda.Size = new System.Drawing.Size(950, 316);
            this.dgvPonuda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(312, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dodavanje nove ponude";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(12, 496);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(113, 17);
            this.labelNaziv.TabIndex = 3;
            this.labelNaziv.Text = "Naziv proizvoda:";
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(402, 496);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(61, 17);
            this.labelKolicina.TabIndex = 4;
            this.labelKolicina.Text = "Količina:";
            // 
            // btnDodajPonudu
            // 
            this.btnDodajPonudu.Location = new System.Drawing.Point(394, 589);
            this.btnDodajPonudu.Name = "btnDodajPonudu";
            this.btnDodajPonudu.Size = new System.Drawing.Size(197, 53);
            this.btnDodajPonudu.TabIndex = 11;
            this.btnDodajPonudu.Text = "Dodaj ponudu";
            this.btnDodajPonudu.UseVisualStyleBackColor = true;
            this.btnDodajPonudu.Click += new System.EventHandler(this.btnDodajPonudu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(394, 657);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(197, 53);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cijena:";
            // 
            // cmbNazivProizvoda
            // 
            this.cmbNazivProizvoda.FormattingEnabled = true;
            this.cmbNazivProizvoda.Location = new System.Drawing.Point(12, 524);
            this.cmbNazivProizvoda.Name = "cmbNazivProizvoda";
            this.cmbNazivProizvoda.Size = new System.Drawing.Size(186, 24);
            this.cmbNazivProizvoda.TabIndex = 14;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(406, 525);
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(185, 22);
            this.numKolicina.TabIndex = 15;
            // 
            // numCijena
            // 
            this.numCijena.DecimalPlaces = 2;
            this.numCijena.Location = new System.Drawing.Point(775, 524);
            this.numCijena.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCijena.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(185, 22);
            this.numCijena.TabIndex = 16;
            this.numCijena.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // frmUpravljanjePonudom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 743);
            this.Controls.Add(this.numCijena);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.cmbNazivProizvoda);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajPonudu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPonuda);
            this.Controls.Add(this.labelNaslovPopisa);
            this.helpProvider1.SetHelpKeyword(this, "170");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Name = "frmUpravljanjePonudom";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj ponudu";
            this.Load += new System.EventHandler(this.frmDodajProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslovPopisa;
        private System.Windows.Forms.DataGridView dgvPonuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.Button btnDodajPonudu;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNazivProizvoda;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.NumericUpDown numCijena;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}