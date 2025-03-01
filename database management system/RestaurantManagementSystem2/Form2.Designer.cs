namespace RestaurantManagementSystem
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ekleRezervasyon = new System.Windows.Forms.Button();
            this.guncelleRezervasyon = new System.Windows.Forms.Button();
            this.silRezervasyon = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.geriButton = new System.Windows.Forms.Button();
            this.mtbBaslangicSaat = new System.Windows.Forms.MaskedTextBox();
            this.mtbBitisSaat = new System.Windows.Forms.MaskedTextBox();
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.cmbMasaID = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // ekleRezervasyon
            // 
            this.ekleRezervasyon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ekleRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekleRezervasyon.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.ekleRezervasyon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekleRezervasyon.Location = new System.Drawing.Point(48, 498);
            this.ekleRezervasyon.Name = "ekleRezervasyon";
            this.ekleRezervasyon.Size = new System.Drawing.Size(180, 85);
            this.ekleRezervasyon.TabIndex = 1;
            this.ekleRezervasyon.Text = "Ekle";
            this.ekleRezervasyon.UseVisualStyleBackColor = false;
            this.ekleRezervasyon.Click += new System.EventHandler(this.ekleRezervasyon_Click);
            // 
            // guncelleRezervasyon
            // 
            this.guncelleRezervasyon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guncelleRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncelleRezervasyon.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.guncelleRezervasyon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelleRezervasyon.Location = new System.Drawing.Point(248, 498);
            this.guncelleRezervasyon.Name = "guncelleRezervasyon";
            this.guncelleRezervasyon.Size = new System.Drawing.Size(180, 85);
            this.guncelleRezervasyon.TabIndex = 2;
            this.guncelleRezervasyon.Text = "Güncelle";
            this.guncelleRezervasyon.UseVisualStyleBackColor = false;
            this.guncelleRezervasyon.Click += new System.EventHandler(this.guncelleRezervasyon_Click);
            // 
            // silRezervasyon
            // 
            this.silRezervasyon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.silRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.silRezervasyon.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.silRezervasyon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silRezervasyon.Location = new System.Drawing.Point(147, 589);
            this.silRezervasyon.Name = "silRezervasyon";
            this.silRezervasyon.Size = new System.Drawing.Size(180, 85);
            this.silRezervasyon.TabIndex = 3;
            this.silRezervasyon.Text = "Sil";
            this.silRezervasyon.UseVisualStyleBackColor = false;
            this.silRezervasyon.Click += new System.EventHandler(this.silRezervasyon_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtAdSoyad.Location = new System.Drawing.Point(74, 111);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(354, 39);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(74, 330);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(354, 34);
            this.dtpTarih.TabIndex = 10;
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.geriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geriButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geriButton.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriButton.Location = new System.Drawing.Point(48, 28);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(60, 64);
            this.geriButton.TabIndex = 16;
            this.geriButton.Text = "<";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // mtbBaslangicSaat
            // 
            this.mtbBaslangicSaat.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.mtbBaslangicSaat.Location = new System.Drawing.Point(83, 415);
            this.mtbBaslangicSaat.Mask = "00:00:00";
            this.mtbBaslangicSaat.Name = "mtbBaslangicSaat";
            this.mtbBaslangicSaat.Size = new System.Drawing.Size(90, 31);
            this.mtbBaslangicSaat.TabIndex = 17;
            // 
            // mtbBitisSaat
            // 
            this.mtbBitisSaat.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.mtbBitisSaat.Location = new System.Drawing.Point(307, 415);
            this.mtbBitisSaat.Mask = "00:00:00";
            this.mtbBitisSaat.Name = "mtbBitisSaat";
            this.mtbBitisSaat.Size = new System.Drawing.Size(90, 31);
            this.mtbBitisSaat.TabIndex = 18;
            this.mtbBitisSaat.ValidatingType = typeof(System.DateTime);
            // 
            // dgvRezervasyonlar
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DeepPink;
            this.dgvRezervasyonlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRezervasyonlar.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervasyonlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRezervasyonlar.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRezervasyonlar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(470, 111);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervasyonlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRezervasyonlar.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DeepPink;
            this.dgvRezervasyonlar.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRezervasyonlar.RowTemplate.Height = 24;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(871, 532);
            this.dgvRezervasyonlar.TabIndex = 19;
            this.dgvRezervasyonlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervasyonlar_CellClick_1);
            // 
            // cmbMasaID
            // 
            this.cmbMasaID.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMasaID.FormattingEnabled = true;
            this.cmbMasaID.Location = new System.Drawing.Point(272, 274);
            this.cmbMasaID.Name = "cmbMasaID";
            this.cmbMasaID.Size = new System.Drawing.Size(156, 41);
            this.cmbMasaID.TabIndex = 20;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtTelefon.Location = new System.Drawing.Point(74, 165);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(354, 39);
            this.txtTelefon.TabIndex = 21;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(77, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Başlangıç Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(301, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bitiş Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(87, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 39);
            this.label4.TabIndex = 25;
            this.label4.Text = "Masa No:";
            // 
            // nudKisiSayisi
            // 
            this.nudKisiSayisi.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.nudKisiSayisi.Location = new System.Drawing.Point(272, 220);
            this.nudKisiSayisi.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudKisiSayisi.Name = "nudKisiSayisi";
            this.nudKisiSayisi.Size = new System.Drawing.Size(156, 39);
            this.nudKisiSayisi.TabIndex = 27;
            this.nudKisiSayisi.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(87, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kişi Sayısı:";
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Location = new System.Drawing.Point(1254, 26);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(87, 68);
            this.cikis.TabIndex = 36;
            this.cikis.Text = "X";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudKisiSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.cmbMasaID);
            this.Controls.Add(this.dgvRezervasyonlar);
            this.Controls.Add(this.mtbBitisSaat);
            this.Controls.Add(this.mtbBaslangicSaat);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.silRezervasyon);
            this.Controls.Add(this.guncelleRezervasyon);
            this.Controls.Add(this.ekleRezervasyon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ekleRezervasyon;
        private System.Windows.Forms.Button guncelleRezervasyon;
        private System.Windows.Forms.Button silRezervasyon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.MaskedTextBox mtbBaslangicSaat;
        private System.Windows.Forms.MaskedTextBox mtbBitisSaat;
        private System.Windows.Forms.DataGridView dgvRezervasyonlar;
        private System.Windows.Forms.ComboBox cmbMasaID;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudKisiSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cikis;
    }
}