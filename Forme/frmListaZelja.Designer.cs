
namespace OnlineFanShop
{
    partial class frmListaZelja
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
            this.dgvListaZelja = new System.Windows.Forms.DataGridView();
            this.cbObavijesti = new System.Windows.Forms.CheckBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZelja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaZelja
            // 
            this.dgvListaZelja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaZelja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaZelja.Location = new System.Drawing.Point(5, 6);
            this.dgvListaZelja.Name = "dgvListaZelja";
            this.dgvListaZelja.Size = new System.Drawing.Size(674, 303);
            this.dgvListaZelja.TabIndex = 0;
            // 
            // cbObavijesti
            // 
            this.cbObavijesti.AutoSize = true;
            this.cbObavijesti.Location = new System.Drawing.Point(12, 320);
            this.cbObavijesti.Name = "cbObavijesti";
            this.cbObavijesti.Size = new System.Drawing.Size(421, 17);
            this.cbObavijesti.TabIndex = 1;
            this.cbObavijesti.Text = "Želim primati obavijesti na email ako dođe do promijene cijene proizvoda sa ove l" +
    "iste";
            this.cbObavijesti.UseVisualStyleBackColor = true;
            this.cbObavijesti.CheckedChanged += new System.EventHandler(this.cbObavijesti_CheckedChanged);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Enabled = false;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(453, 313);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(110, 29);
            this.btnSpremiPromjene.TabIndex = 2;
            this.btnSpremiPromjene.Text = "Spremi odabir";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(569, 313);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(110, 29);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši s liste";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmListaZelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 349);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.cbObavijesti);
            this.Controls.Add(this.dgvListaZelja);
            this.helpProvider1.SetHelpKeyword(this, "70");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Name = "frmListaZelja";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Želja";
            this.Load += new System.EventHandler(this.frmListaZelja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZelja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaZelja;
        private System.Windows.Forms.CheckBox cbObavijesti;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnObrisi;
    }
}