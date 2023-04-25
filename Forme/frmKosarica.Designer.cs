
namespace OnlineFanShop
{
    partial class frmKosarica
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
            this.dgvKosarica = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDovrsiKupnju = new System.Windows.Forms.Button();
            this.btnFanKviz = new System.Windows.Forms.Button();
            this.btnMakniProizvod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKonacniIznos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOdabraniProizvod = new System.Windows.Forms.TextBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKosarica
            // 
            this.dgvKosarica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKosarica.Location = new System.Drawing.Point(7, 7);
            this.dgvKosarica.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKosarica.Name = "dgvKosarica";
            this.dgvKosarica.RowHeadersWidth = 51;
            this.dgvKosarica.Size = new System.Drawing.Size(878, 340);
            this.dgvKosarica.TabIndex = 0;
            this.dgvKosarica.SelectionChanged += new System.EventHandler(this.dgvKosarica_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(129, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odabirom jednog od proizvoda u Vašoj košarici imate priliku riješiti fan kviz te " +
    "ostvariti popust!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(220, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fan kviz će biti iste tematike kao i odabrani proizvod, birajte pametno!";
            // 
            // btnDovrsiKupnju
            // 
            this.btnDovrsiKupnju.Location = new System.Drawing.Point(753, 569);
            this.btnDovrsiKupnju.Margin = new System.Windows.Forms.Padding(4);
            this.btnDovrsiKupnju.Name = "btnDovrsiKupnju";
            this.btnDovrsiKupnju.Size = new System.Drawing.Size(132, 43);
            this.btnDovrsiKupnju.TabIndex = 3;
            this.btnDovrsiKupnju.Text = "Dovrši kupnju";
            this.btnDovrsiKupnju.UseVisualStyleBackColor = true;
            this.btnDovrsiKupnju.Click += new System.EventHandler(this.btnDovrsiKupnju_Click);
            // 
            // btnFanKviz
            // 
            this.btnFanKviz.Location = new System.Drawing.Point(7, 415);
            this.btnFanKviz.Margin = new System.Windows.Forms.Padding(4);
            this.btnFanKviz.Name = "btnFanKviz";
            this.btnFanKviz.Size = new System.Drawing.Size(132, 43);
            this.btnFanKviz.TabIndex = 4;
            this.btnFanKviz.Text = "Fan kviz";
            this.btnFanKviz.UseVisualStyleBackColor = true;
            this.btnFanKviz.Click += new System.EventHandler(this.btnFanKviz_Click);
            // 
            // btnMakniProizvod
            // 
            this.btnMakniProizvod.Location = new System.Drawing.Point(753, 415);
            this.btnMakniProizvod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakniProizvod.Name = "btnMakniProizvod";
            this.btnMakniProizvod.Size = new System.Drawing.Size(132, 43);
            this.btnMakniProizvod.TabIndex = 5;
            this.btnMakniProizvod.Text = "Makni proizvod";
            this.btnMakniProizvod.UseVisualStyleBackColor = true;
            this.btnMakniProizvod.Click += new System.EventHandler(this.btnMakniProizvod_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(327, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Podaci o kupnji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ukupan iznos: ";
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUkupanIznos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUkupanIznos.Location = new System.Drawing.Point(140, 556);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.ReadOnly = true;
            this.txtUkupanIznos.Size = new System.Drawing.Size(91, 15);
            this.txtUkupanIznos.TabIndex = 7;
            // 
            // txtPopust
            // 
            this.txtPopust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPopust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPopust.Location = new System.Drawing.Point(140, 606);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.ReadOnly = true;
            this.txtPopust.Size = new System.Drawing.Size(91, 15);
            this.txtPopust.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Popust:";
            // 
            // txtKonacniIznos
            // 
            this.txtKonacniIznos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKonacniIznos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKonacniIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKonacniIznos.Location = new System.Drawing.Point(509, 574);
            this.txtKonacniIznos.Name = "txtKonacniIznos";
            this.txtKonacniIznos.ReadOnly = true;
            this.txtKonacniIznos.Size = new System.Drawing.Size(114, 27);
            this.txtKonacniIznos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(328, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Konačni iznos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "kn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "kn";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Odabrani proizvod: ";
            // 
            // txtOdabraniProizvod
            // 
            this.txtOdabraniProizvod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOdabraniProizvod.ForeColor = System.Drawing.Color.Silver;
            this.txtOdabraniProizvod.Location = new System.Drawing.Point(314, 425);
            this.txtOdabraniProizvod.Name = "txtOdabraniProizvod";
            this.txtOdabraniProizvod.ReadOnly = true;
            this.txtOdabraniProizvod.Size = new System.Drawing.Size(217, 15);
            this.txtOdabraniProizvod.TabIndex = 16;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(678, 428);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(72, 22);
            this.numKolicina.TabIndex = 17;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Količina:";
            // 
            // frmKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 661);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.txtOdabraniProizvod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKonacniIznos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMakniProizvod);
            this.Controls.Add(this.btnFanKviz);
            this.Controls.Add(this.btnDovrsiKupnju);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKosarica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "140");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmKosarica";
            this.helpProvider1.SetShowHelp(this, true);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kosarica";
            this.Load += new System.EventHandler(this.frmKosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKosarica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDovrsiKupnju;
        private System.Windows.Forms.Button btnFanKviz;
        private System.Windows.Forms.Button btnMakniProizvod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKonacniIznos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOdabraniProizvod;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label10;
    }
}