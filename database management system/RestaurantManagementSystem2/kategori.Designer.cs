namespace RestaurantManagementSystem
{
    partial class kategori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.ekleKategori = new System.Windows.Forms.Button();
            this.guncelleKategori = new System.Windows.Forms.Button();
            this.silKategori = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.dgvMalzemeler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.malzemeGuncelle = new System.Windows.Forms.Button();
            this.malzemeSil = new System.Windows.Forms.Button();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.numMiktar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.malzemeEkle = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKategoriler
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKategoriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKategoriler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKategoriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKategoriler.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKategoriler.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvKategoriler.Location = new System.Drawing.Point(706, 59);
            this.dgvKategoriler.Name = "dgvKategoriler";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKategoriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvKategoriler.RowHeadersWidth = 80;
            this.dgvKategoriler.RowTemplate.Height = 24;
            this.dgvKategoriler.Size = new System.Drawing.Size(369, 243);
            this.dgvKategoriler.TabIndex = 1;
            // 
            // ekleKategori
            // 
            this.ekleKategori.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ekleKategori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekleKategori.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.ekleKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekleKategori.Location = new System.Drawing.Point(67, 217);
            this.ekleKategori.Name = "ekleKategori";
            this.ekleKategori.Size = new System.Drawing.Size(171, 85);
            this.ekleKategori.TabIndex = 2;
            this.ekleKategori.Text = "Ekle";
            this.ekleKategori.UseVisualStyleBackColor = false;
            this.ekleKategori.Click += new System.EventHandler(this.ekleKategori_Click);
            // 
            // guncelleKategori
            // 
            this.guncelleKategori.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guncelleKategori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncelleKategori.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.guncelleKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelleKategori.Location = new System.Drawing.Point(288, 217);
            this.guncelleKategori.Name = "guncelleKategori";
            this.guncelleKategori.Size = new System.Drawing.Size(171, 85);
            this.guncelleKategori.TabIndex = 3;
            this.guncelleKategori.Text = "Güncelle";
            this.guncelleKategori.UseVisualStyleBackColor = false;
            this.guncelleKategori.Click += new System.EventHandler(this.guncelleKategori_Click);
            // 
            // silKategori
            // 
            this.silKategori.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.silKategori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.silKategori.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.silKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silKategori.Location = new System.Drawing.Point(501, 217);
            this.silKategori.Name = "silKategori";
            this.silKategori.Size = new System.Drawing.Size(171, 85);
            this.silKategori.TabIndex = 4;
            this.silKategori.Text = "Sil";
            this.silKategori.UseVisualStyleBackColor = false;
            this.silKategori.Click += new System.EventHandler(this.silKategori_Click);
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geriButton.Font = new System.Drawing.Font("Gill Sans MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriButton.Location = new System.Drawing.Point(67, 29);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(73, 65);
            this.geriButton.TabIndex = 17;
            this.geriButton.Text = "<";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategoriAdi.Location = new System.Drawing.Point(173, 145);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(403, 39);
            this.txtKategoriAdi.TabIndex = 18;
            // 
            // dgvMalzemeler
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMalzemeler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMalzemeler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMalzemeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMalzemeler.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMalzemeler.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMalzemeler.Location = new System.Drawing.Point(706, 445);
            this.dgvMalzemeler.Name = "dgvMalzemeler";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMalzemeler.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMalzemeler.RowHeadersWidth = 80;
            this.dgvMalzemeler.RowTemplate.Height = 24;
            this.dgvMalzemeler.Size = new System.Drawing.Size(369, 249);
            this.dgvMalzemeler.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(710, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kategori Tablosu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(710, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Malzeme Tablosu:";
            // 
            // malzemeGuncelle
            // 
            this.malzemeGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.malzemeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.malzemeGuncelle.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.malzemeGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.malzemeGuncelle.Location = new System.Drawing.Point(271, 609);
            this.malzemeGuncelle.Name = "malzemeGuncelle";
            this.malzemeGuncelle.Size = new System.Drawing.Size(180, 85);
            this.malzemeGuncelle.TabIndex = 23;
            this.malzemeGuncelle.Text = "Güncelle";
            this.malzemeGuncelle.UseVisualStyleBackColor = false;
            this.malzemeGuncelle.Click += new System.EventHandler(this.malzemeGuncelle_Click);
            // 
            // malzemeSil
            // 
            this.malzemeSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.malzemeSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.malzemeSil.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.malzemeSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.malzemeSil.Location = new System.Drawing.Point(480, 609);
            this.malzemeSil.Name = "malzemeSil";
            this.malzemeSil.Size = new System.Drawing.Size(180, 85);
            this.malzemeSil.TabIndex = 24;
            this.malzemeSil.Text = "Sil";
            this.malzemeSil.UseVisualStyleBackColor = false;
            this.malzemeSil.Click += new System.EventHandler(this.malzemeSil_Click);
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMalzemeAdi.Location = new System.Drawing.Point(173, 474);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(403, 39);
            this.txtMalzemeAdi.TabIndex = 25;
            // 
            // numMiktar
            // 
            this.numMiktar.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.numMiktar.Location = new System.Drawing.Point(462, 545);
            this.numMiktar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMiktar.Name = "numMiktar";
            this.numMiktar.Size = new System.Drawing.Size(114, 39);
            this.numMiktar.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(166, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 39);
            this.label3.TabIndex = 27;
            this.label3.Text = "Malzeme Miktarı:";
            // 
            // malzemeEkle
            // 
            this.malzemeEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.malzemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.malzemeEkle.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.malzemeEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.malzemeEkle.Location = new System.Drawing.Point(64, 609);
            this.malzemeEkle.Name = "malzemeEkle";
            this.malzemeEkle.Size = new System.Drawing.Size(180, 85);
            this.malzemeEkle.TabIndex = 28;
            this.malzemeEkle.Text = "Ekle";
            this.malzemeEkle.UseVisualStyleBackColor = false;
            this.malzemeEkle.Click += new System.EventHandler(this.malzemeEkle_Click_1);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Location = new System.Drawing.Point(1147, 25);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(87, 68);
            this.cikis.TabIndex = 36;
            this.cikis.Text = "X";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.malzemeEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMiktar);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.malzemeSil);
            this.Controls.Add(this.malzemeGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMalzemeler);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.silKategori);
            this.Controls.Add(this.guncelleKategori);
            this.Controls.Add(this.ekleKategori);
            this.Controls.Add(this.dgvKategoriler);
            this.Name = "kategori";
            this.Text = "kategori";
            this.Load += new System.EventHandler(this.kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.Button ekleKategori;
        private System.Windows.Forms.Button guncelleKategori;
        private System.Windows.Forms.Button silKategori;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.DataGridView dgvMalzemeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button malzemeGuncelle;
        private System.Windows.Forms.Button malzemeSil;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.NumericUpDown numMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button malzemeEkle;
        private System.Windows.Forms.Button cikis;
    }
}