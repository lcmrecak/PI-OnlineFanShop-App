
namespace OnlineFanShop
{
    partial class frmDetaljiZaprimanja
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
            this.dgvDetalji = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalji
            // 
            this.dgvDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalji.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalji.Name = "dgvDetalji";
            this.dgvDetalji.Size = new System.Drawing.Size(739, 261);
            this.dgvDetalji.TabIndex = 0;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // frmDetaljiZaprimanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 261);
            this.Controls.Add(this.dgvDetalji);
            this.helpProvider1.SetHelpKeyword(this, "90");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MaximizeBox = false;
            this.Name = "frmDetaljiZaprimanja";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji Zaprimanja";
            this.Load += new System.EventHandler(this.frmDetaljiZaprimanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalji;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}