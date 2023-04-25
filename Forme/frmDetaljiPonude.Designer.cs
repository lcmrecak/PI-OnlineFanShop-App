
namespace OnlineFanShop
{
    partial class frmDetaljiPonude
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
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtVelicina = new System.Windows.Forms.TextBox();
            this.txtFransiza = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvOcjeneKomentari = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnesiKomentar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnesiOcjenu = new System.Windows.Forms.TextBox();
            this.btnPotvrdiRecenziju = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjeneKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(604, 89);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(96, 20);
            this.txtOcjena.TabIndex = 31;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(604, 37);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(96, 20);
            this.txtCijena.TabIndex = 30;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(604, 11);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(96, 20);
            this.txtKolicina.TabIndex = 29;
            // 
            // txtVelicina
            // 
            this.txtVelicina.Location = new System.Drawing.Point(152, 89);
            this.txtVelicina.Name = "txtVelicina";
            this.txtVelicina.Size = new System.Drawing.Size(234, 20);
            this.txtVelicina.TabIndex = 28;
            // 
            // txtFransiza
            // 
            this.txtFransiza.Location = new System.Drawing.Point(152, 63);
            this.txtFransiza.Name = "txtFransiza";
            this.txtFransiza.Size = new System.Drawing.Size(234, 20);
            this.txtFransiza.TabIndex = 27;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(152, 37);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(234, 20);
            this.txtVrsta.TabIndex = 26;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(152, 11);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(234, 20);
            this.txtNaziv.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ocjene i komentari proizvoda:";
            // 
            // dgvOcjeneKomentari
            // 
            this.dgvOcjeneKomentari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOcjeneKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjeneKomentari.Location = new System.Drawing.Point(15, 148);
            this.dgvOcjeneKomentari.Name = "dgvOcjeneKomentari";
            this.dgvOcjeneKomentari.Size = new System.Drawing.Size(773, 249);
            this.dgvOcjeneKomentari.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(408, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Prosječna ocjena proizvoda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(408, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cijena jednog proizvoda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(408, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dostupna količina proizvoda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Veličina proizvoda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Franšiza proizvoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vrsta proizvoda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Naziv proizvoda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(17, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Unesite komentar:";
            // 
            // txtUnesiKomentar
            // 
            this.txtUnesiKomentar.Location = new System.Drawing.Point(146, 412);
            this.txtUnesiKomentar.Name = "txtUnesiKomentar";
            this.txtUnesiKomentar.Size = new System.Drawing.Size(234, 20);
            this.txtUnesiKomentar.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(408, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Unesite ocjenu:";
            // 
            // txtUnesiOcjenu
            // 
            this.txtUnesiOcjenu.Location = new System.Drawing.Point(520, 411);
            this.txtUnesiOcjenu.Name = "txtUnesiOcjenu";
            this.txtUnesiOcjenu.Size = new System.Drawing.Size(52, 20);
            this.txtUnesiOcjenu.TabIndex = 35;
            // 
            // btnPotvrdiRecenziju
            // 
            this.btnPotvrdiRecenziju.Location = new System.Drawing.Point(634, 409);
            this.btnPotvrdiRecenziju.Name = "btnPotvrdiRecenziju";
            this.btnPotvrdiRecenziju.Size = new System.Drawing.Size(154, 23);
            this.btnPotvrdiRecenziju.TabIndex = 36;
            this.btnPotvrdiRecenziju.Text = "Potvrdi recenziju";
            this.btnPotvrdiRecenziju.UseVisualStyleBackColor = true;
            this.btnPotvrdiRecenziju.Click += new System.EventHandler(this.btnPotvrdiRecenziju_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // frmDetaljiPonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPotvrdiRecenziju);
            this.Controls.Add(this.txtUnesiOcjenu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUnesiKomentar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtVelicina);
            this.Controls.Add(this.txtFransiza);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvOcjeneKomentari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpKeyword(this, "60");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Name = "frmDetaljiPonude";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji selektirane ponude";
            this.Load += new System.EventHandler(this.frmDetaljiPonude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjeneKomentari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtVelicina;
        private System.Windows.Forms.TextBox txtFransiza;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvOcjeneKomentari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUnesiKomentar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnesiOcjenu;
        private System.Windows.Forms.Button btnPotvrdiRecenziju;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}