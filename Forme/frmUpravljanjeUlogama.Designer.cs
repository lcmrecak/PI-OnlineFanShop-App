
namespace OnlineFanShop
{
    partial class frmUpravljanjeUlogama
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
            this.btnDetaljiModeratora = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetaljiKorisnika = new System.Windows.Forms.Button();
            this.btnUkloniModeratora = new System.Windows.Forms.Button();
            this.btnDodajModeratora = new System.Windows.Forms.Button();
            this.dgvModeratori = new System.Windows.Forms.DataGridView();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeratori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetaljiModeratora
            // 
            this.btnDetaljiModeratora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDetaljiModeratora.Location = new System.Drawing.Point(419, 391);
            this.btnDetaljiModeratora.Name = "btnDetaljiModeratora";
            this.btnDetaljiModeratora.Size = new System.Drawing.Size(370, 50);
            this.btnDetaljiModeratora.TabIndex = 27;
            this.btnDetaljiModeratora.Text = "Prikaži detalje moderatora";
            this.btnDetaljiModeratora.UseVisualStyleBackColor = true;
            this.btnDetaljiModeratora.Click += new System.EventHandler(this.btnDetaljiModeratora_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(524, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Popis moderatora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Popis registriranih korisnika";
            // 
            // btnDetaljiKorisnika
            // 
            this.btnDetaljiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDetaljiKorisnika.Location = new System.Drawing.Point(11, 391);
            this.btnDetaljiKorisnika.Name = "btnDetaljiKorisnika";
            this.btnDetaljiKorisnika.Size = new System.Drawing.Size(370, 50);
            this.btnDetaljiKorisnika.TabIndex = 24;
            this.btnDetaljiKorisnika.Text = "Prikaži detalje  registriranoga korisnika";
            this.btnDetaljiKorisnika.UseVisualStyleBackColor = true;
            this.btnDetaljiKorisnika.Click += new System.EventHandler(this.btnDetaljiKorisnika_Click);
            // 
            // btnUkloniModeratora
            // 
            this.btnUkloniModeratora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUkloniModeratora.Location = new System.Drawing.Point(419, 326);
            this.btnUkloniModeratora.Name = "btnUkloniModeratora";
            this.btnUkloniModeratora.Size = new System.Drawing.Size(260, 29);
            this.btnUkloniModeratora.TabIndex = 23;
            this.btnUkloniModeratora.Text = "<<<- Makni ulogu moderatora";
            this.btnUkloniModeratora.UseVisualStyleBackColor = true;
            this.btnUkloniModeratora.Click += new System.EventHandler(this.btnUkloniModeratora_Click);
            // 
            // btnDodajModeratora
            // 
            this.btnDodajModeratora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajModeratora.Location = new System.Drawing.Point(121, 326);
            this.btnDodajModeratora.Name = "btnDodajModeratora";
            this.btnDodajModeratora.Size = new System.Drawing.Size(260, 29);
            this.btnDodajModeratora.TabIndex = 22;
            this.btnDodajModeratora.Text = "Dodijeli ulogu moderatora ->>>";
            this.btnDodajModeratora.UseVisualStyleBackColor = true;
            this.btnDodajModeratora.Click += new System.EventHandler(this.btnDodajModeratora_Click);
            // 
            // dgvModeratori
            // 
            this.dgvModeratori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModeratori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModeratori.Location = new System.Drawing.Point(419, 37);
            this.dgvModeratori.Name = "dgvModeratori";
            this.dgvModeratori.Size = new System.Drawing.Size(370, 271);
            this.dgvModeratori.TabIndex = 21;
            this.dgvModeratori.TabStop = false;
            this.dgvModeratori.SelectionChanged += new System.EventHandler(this.dgvModeratori_SelectionChanged);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(11, 37);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(370, 271);
            this.dgvKorisnici.TabIndex = 20;
            this.dgvKorisnici.TabStop = false;
            this.dgvKorisnici.SelectionChanged += new System.EventHandler(this.dgvKorisnici_SelectionChanged);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // frmUpravljanjeUlogama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetaljiModeratora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetaljiKorisnika);
            this.Controls.Add(this.btnUkloniModeratora);
            this.Controls.Add(this.btnDodajModeratora);
            this.Controls.Add(this.dgvModeratori);
            this.Controls.Add(this.dgvKorisnici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "100");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Name = "frmUpravljanjeUlogama";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upravljanje ulogama korisnika";
            this.Load += new System.EventHandler(this.frmUpravljanjeUlogama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeratori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetaljiModeratora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetaljiKorisnika;
        private System.Windows.Forms.Button btnUkloniModeratora;
        private System.Windows.Forms.Button btnDodajModeratora;
        private System.Windows.Forms.DataGridView dgvModeratori;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}