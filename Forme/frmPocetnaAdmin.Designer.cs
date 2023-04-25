
namespace OnlineFanShop
{
    partial class frmPocetnaAdmin
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
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.btnDodajNaListuZelja = new System.Windows.Forms.Button();
            this.btnDodajUKosaricu = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.cmbFranšiza = new System.Windows.Forms.ComboBox();
            this.cmbVeličina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpravljanjePonudom = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.btnListaZelja = new System.Windows.Forms.Button();
            this.btnUpravljanjeUlogama = new System.Windows.Forms.Button();
            this.btnZaprimanjeRobe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijenaMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCijenaMin = new System.Windows.Forms.TextBox();
            this.dgvPonuda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetiraj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDodano = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnUrediPonudu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(968, 485);
            this.btnPrikaziDetalje.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(373, 38);
            this.btnPrikaziDetalje.TabIndex = 22;
            this.btnPrikaziDetalje.Text = "Prikaži detalje o proizvodu";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // btnDodajNaListuZelja
            // 
            this.btnDodajNaListuZelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajNaListuZelja.Location = new System.Drawing.Point(968, 576);
            this.btnDodajNaListuZelja.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajNaListuZelja.Name = "btnDodajNaListuZelja";
            this.btnDodajNaListuZelja.Size = new System.Drawing.Size(373, 38);
            this.btnDodajNaListuZelja.TabIndex = 21;
            this.btnDodajNaListuZelja.Text = "Dodaj na listu želja";
            this.btnDodajNaListuZelja.UseVisualStyleBackColor = true;
            this.btnDodajNaListuZelja.Click += new System.EventHandler(this.btnDodajNaListuZelja_Click);
            // 
            // btnDodajUKosaricu
            // 
            this.btnDodajUKosaricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajUKosaricu.Location = new System.Drawing.Point(968, 530);
            this.btnDodajUKosaricu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajUKosaricu.Name = "btnDodajUKosaricu";
            this.btnDodajUKosaricu.Size = new System.Drawing.Size(373, 38);
            this.btnDodajUKosaricu.TabIndex = 20;
            this.btnDodajUKosaricu.Text = "Dodaj u košaricu";
            this.btnDodajUKosaricu.UseVisualStyleBackColor = true;
            this.btnDodajUKosaricu.Click += new System.EventHandler(this.btnDodajUKosaricu_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPretrazi.Location = new System.Drawing.Point(280, 162);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(288, 29);
            this.txtPretrazi.TabIndex = 19;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(735, 161);
            this.cmbSortiranje.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(212, 24);
            this.cmbSortiranje.TabIndex = 15;
            this.cmbSortiranje.SelectedIndexChanged += new System.EventHandler(this.cmbSortiranje_SelectedIndexChanged);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.btnUpravljanjePonudom);
            this.groupBox1.Controls.Add(this.btnIzvjestaj);
            this.groupBox1.Controls.Add(this.btnOdjava);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKosarica);
            this.groupBox1.Controls.Add(this.btnListaZelja);
            this.groupBox1.Controls.Add(this.btnUpravljanjeUlogama);
            this.groupBox1.Controls.Add(this.btnZaprimanjeRobe);
            this.groupBox1.Location = new System.Drawing.Point(-4, -9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1365, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnUpravljanjePonudom
            // 
            this.btnUpravljanjePonudom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpravljanjePonudom.Location = new System.Drawing.Point(977, 92);
            this.btnUpravljanjePonudom.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpravljanjePonudom.Name = "btnUpravljanjePonudom";
            this.btnUpravljanjePonudom.Size = new System.Drawing.Size(200, 43);
            this.btnUpravljanjePonudom.TabIndex = 9;
            this.btnUpravljanjePonudom.Text = "Upravljanje ponudom";
            this.btnUpravljanjePonudom.UseVisualStyleBackColor = true;
            this.btnUpravljanjePonudom.Click += new System.EventHandler(this.btnUpravljanjePonudom_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIzvjestaj.Location = new System.Drawing.Point(11, 15);
            this.btnIzvjestaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(195, 37);
            this.btnIzvjestaj.TabIndex = 8;
            this.btnIzvjestaj.Text = "Generiraj izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(1255, 20);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(91, 32);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
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
            this.btnKosarica.Location = new System.Drawing.Point(132, 92);
            this.btnKosarica.Margin = new System.Windows.Forms.Padding(4);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(200, 43);
            this.btnKosarica.TabIndex = 0;
            this.btnKosarica.Text = "Kosarica";
            this.btnKosarica.UseVisualStyleBackColor = true;
            this.btnKosarica.Click += new System.EventHandler(this.btnKosarica_Click);
            // 
            // btnListaZelja
            // 
            this.btnListaZelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListaZelja.Location = new System.Drawing.Point(341, 92);
            this.btnListaZelja.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaZelja.Name = "btnListaZelja";
            this.btnListaZelja.Size = new System.Drawing.Size(200, 43);
            this.btnListaZelja.TabIndex = 1;
            this.btnListaZelja.Text = "Lista Zelja";
            this.btnListaZelja.UseVisualStyleBackColor = true;
            this.btnListaZelja.Click += new System.EventHandler(this.btnListaZelja_Click);
            // 
            // btnUpravljanjeUlogama
            // 
            this.btnUpravljanjeUlogama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpravljanjeUlogama.Location = new System.Drawing.Point(763, 92);
            this.btnUpravljanjeUlogama.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpravljanjeUlogama.Name = "btnUpravljanjeUlogama";
            this.btnUpravljanjeUlogama.Size = new System.Drawing.Size(200, 43);
            this.btnUpravljanjeUlogama.TabIndex = 3;
            this.btnUpravljanjeUlogama.Text = "Upravljanje ulogama";
            this.btnUpravljanjeUlogama.UseVisualStyleBackColor = true;
            this.btnUpravljanjeUlogama.Click += new System.EventHandler(this.btnUpravljanjeUlogama_Click);
            // 
            // btnZaprimanjeRobe
            // 
            this.btnZaprimanjeRobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnZaprimanjeRobe.Location = new System.Drawing.Point(553, 92);
            this.btnZaprimanjeRobe.Margin = new System.Windows.Forms.Padding(4);
            this.btnZaprimanjeRobe.Name = "btnZaprimanjeRobe";
            this.btnZaprimanjeRobe.Size = new System.Drawing.Size(200, 43);
            this.btnZaprimanjeRobe.TabIndex = 2;
            this.btnZaprimanjeRobe.Text = "Zaprimanje robe";
            this.btnZaprimanjeRobe.UseVisualStyleBackColor = true;
            this.btnZaprimanjeRobe.Click += new System.EventHandler(this.btnZaprimanjeRobe_Click);
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
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtriranje";
            // 
            // txtCijenaMin
            // 
            this.txtCijenaMin.Location = new System.Drawing.Point(113, 31);
            this.txtCijenaMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijenaMin.Name = "txtCijenaMin";
            this.txtCijenaMin.Size = new System.Drawing.Size(103, 26);
            this.txtCijenaMin.TabIndex = 1;
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
            this.dgvPonuda.TabIndex = 14;
            this.dgvPonuda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPonuda_CellContentClick);
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
            this.label2.TabIndex = 16;
            this.label2.Text = "Sortiranje:";
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResetiraj.Location = new System.Drawing.Point(968, 689);
            this.btnResetiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(373, 38);
            this.btnResetiraj.TabIndex = 23;
            this.btnResetiraj.Text = "Resetiraj prikaz ponude";
            this.btnResetiraj.UseVisualStyleBackColor = true;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(16, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pretraži po nazivu proizvoda:";
            // 
            // lblDodano
            // 
            this.lblDodano.AutoSize = true;
            this.lblDodano.Location = new System.Drawing.Point(1077, 631);
            this.lblDodano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDodano.Name = "lblDodano";
            this.lblDodano.Size = new System.Drawing.Size(143, 17);
            this.lblDodano.TabIndex = 26;
            this.lblDodano.Text = "Dodano na listu želja!";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // btnUrediPonudu
            // 
            this.btnUrediPonudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUrediPonudu.Location = new System.Drawing.Point(968, 439);
            this.btnUrediPonudu.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrediPonudu.Name = "btnUrediPonudu";
            this.btnUrediPonudu.Size = new System.Drawing.Size(373, 38);
            this.btnUrediPonudu.TabIndex = 27;
            this.btnUrediPonudu.Text = "Uredi ponudu";
            this.btnUrediPonudu.UseVisualStyleBackColor = true;
            this.btnUrediPonudu.Click += new System.EventHandler(this.btnUrediProizvod_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(973, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Količina:";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(1034, 410);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 22);
            this.numKolicina.TabIndex = 29;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmPocetnaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 759);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUrediPonudu);
            this.Controls.Add(this.lblDodano);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.btnDodajNaListuZelja);
            this.Controls.Add(this.btnDodajUKosaricu);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPonuda);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "40");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPocetnaAdmin";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Online Fan Shop";
            this.Load += new System.EventHandler(this.FrmPocetnaAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.Button btnDodajNaListuZelja;
        private System.Windows.Forms.Button btnDodajUKosaricu;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox cmbFranšiza;
        private System.Windows.Forms.ComboBox cmbVeličina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKosarica;
        private System.Windows.Forms.Button btnListaZelja;
        private System.Windows.Forms.Button btnUpravljanjeUlogama;
        private System.Windows.Forms.Button btnZaprimanjeRobe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijenaMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCijenaMin;
        private System.Windows.Forms.DataGridView dgvPonuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResetiraj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label lblDodano;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Button btnUrediPonudu;
        private System.Windows.Forms.Button btnUpravljanjePonudom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numKolicina;
    }
}