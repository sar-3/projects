namespace RestaurantManagementSystem
{
    partial class yemek
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvYemekler = new System.Windows.Forms.DataGridView();
            this.txtYemekIsmi = new System.Windows.Forms.TextBox();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.yemekEkle = new System.Windows.Forms.Button();
            this.yemekSil = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYemekler
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvYemekler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYemekler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYemekler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYemekler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvYemekler.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvYemekler.Location = new System.Drawing.Point(531, 138);
            this.dgvYemekler.Name = "dgvYemekler";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYemekler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvYemekler.RowHeadersWidth = 80;
            this.dgvYemekler.RowTemplate.Height = 24;
            this.dgvYemekler.Size = new System.Drawing.Size(731, 283);
            this.dgvYemekler.TabIndex = 2;
            // 
            // txtYemekIsmi
            // 
            this.txtYemekIsmi.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYemekIsmi.Location = new System.Drawing.Point(94, 153);
            this.txtYemekIsmi.Name = "txtYemekIsmi";
            this.txtYemekIsmi.Size = new System.Drawing.Size(345, 39);
            this.txtYemekIsmi.TabIndex = 19;
            // 
            // numFiyat
            // 
            this.numFiyat.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.numFiyat.Location = new System.Drawing.Point(288, 211);
            this.numFiyat.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(114, 39);
            this.numFiyat.TabIndex = 27;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(94, 277);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(345, 46);
            this.cmbKategori.TabIndex = 28;
            this.cmbKategori.Text = "Kategori Seçin...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(152, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 39);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fiyat:";
            // 
            // txtIcerik
            // 
            this.txtIcerik.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIcerik.Location = new System.Drawing.Point(94, 353);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(345, 39);
            this.txtIcerik.TabIndex = 30;
            // 
            // yemekEkle
            // 
            this.yemekEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yemekEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yemekEkle.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.yemekEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yemekEkle.Location = new System.Drawing.Point(83, 436);
            this.yemekEkle.Name = "yemekEkle";
            this.yemekEkle.Size = new System.Drawing.Size(180, 85);
            this.yemekEkle.TabIndex = 31;
            this.yemekEkle.Text = "Ekle";
            this.yemekEkle.UseVisualStyleBackColor = false;
            this.yemekEkle.Click += new System.EventHandler(this.yemekEkle_Click);
            // 
            // yemekSil
            // 
            this.yemekSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yemekSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yemekSil.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.yemekSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yemekSil.Location = new System.Drawing.Point(302, 436);
            this.yemekSil.Name = "yemekSil";
            this.yemekSil.Size = new System.Drawing.Size(180, 85);
            this.yemekSil.TabIndex = 33;
            this.yemekSil.Text = "Sil";
            this.yemekSil.UseVisualStyleBackColor = false;
            this.yemekSil.Click += new System.EventHandler(this.yemekSil_Click);
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geriButton.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriButton.Location = new System.Drawing.Point(33, 21);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(87, 68);
            this.geriButton.TabIndex = 34;
            this.geriButton.Text = "<";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Location = new System.Drawing.Point(1175, 21);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(87, 68);
            this.cikis.TabIndex = 35;
            this.cikis.Text = "X";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategoriAdi.Location = new System.Drawing.Point(531, 508);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(510, 39);
            this.txtKategoriAdi.TabIndex = 36;
            // 
            // araButton
            // 
            this.araButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.araButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.araButton.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.araButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.araButton.Location = new System.Drawing.Point(1094, 492);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(126, 74);
            this.araButton.TabIndex = 37;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = false;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // yemek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.yemekSil);
            this.Controls.Add(this.yemekEkle);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.numFiyat);
            this.Controls.Add(this.txtYemekIsmi);
            this.Controls.Add(this.dgvYemekler);
            this.Name = "yemek";
            this.Text = "yemek";
            this.Load += new System.EventHandler(this.yemek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYemekler;
        private System.Windows.Forms.TextBox txtYemekIsmi;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Button yemekEkle;
        private System.Windows.Forms.Button yemekSil;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Button araButton;
    }
}