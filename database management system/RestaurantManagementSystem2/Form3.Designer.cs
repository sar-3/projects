namespace RestaurantManagementSystem
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.cmbMasaID = new System.Windows.Forms.ComboBox();
            this.cmbCalisanID = new System.Windows.Forms.ComboBox();
            this.ekleSiparis = new System.Windows.Forms.Button();
            this.silSiparis = new System.Windows.Forms.Button();
            this.guncelleSiparis = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.yemekEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepPink;
            this.dgvSiparisler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSiparisler.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSiparisler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSiparisler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSiparisler.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSiparisler.Location = new System.Drawing.Point(488, 126);
            this.dgvSiparisler.Name = "dgvSiparisler";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSiparisler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSiparisler.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DeepPink;
            this.dgvSiparisler.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSiparisler.RowTemplate.Height = 24;
            this.dgvSiparisler.Size = new System.Drawing.Size(730, 480);
            this.dgvSiparisler.TabIndex = 20;
            // 
            // cmbMasaID
            // 
            this.cmbMasaID.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbMasaID.FormattingEnabled = true;
            this.cmbMasaID.Location = new System.Drawing.Point(238, 144);
            this.cmbMasaID.Name = "cmbMasaID";
            this.cmbMasaID.Size = new System.Drawing.Size(167, 41);
            this.cmbMasaID.TabIndex = 21;
            // 
            // cmbCalisanID
            // 
            this.cmbCalisanID.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbCalisanID.FormattingEnabled = true;
            this.cmbCalisanID.Location = new System.Drawing.Point(55, 290);
            this.cmbCalisanID.Name = "cmbCalisanID";
            this.cmbCalisanID.Size = new System.Drawing.Size(350, 41);
            this.cmbCalisanID.TabIndex = 23;
            // 
            // ekleSiparis
            // 
            this.ekleSiparis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ekleSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekleSiparis.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.ekleSiparis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekleSiparis.Location = new System.Drawing.Point(35, 404);
            this.ekleSiparis.Name = "ekleSiparis";
            this.ekleSiparis.Size = new System.Drawing.Size(180, 85);
            this.ekleSiparis.TabIndex = 31;
            this.ekleSiparis.Text = "Ekle";
            this.ekleSiparis.UseVisualStyleBackColor = false;
            this.ekleSiparis.Click += new System.EventHandler(this.ekleSiparis_Click);
            // 
            // silSiparis
            // 
            this.silSiparis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.silSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.silSiparis.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.silSiparis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silSiparis.Location = new System.Drawing.Point(267, 404);
            this.silSiparis.Name = "silSiparis";
            this.silSiparis.Size = new System.Drawing.Size(180, 85);
            this.silSiparis.TabIndex = 30;
            this.silSiparis.Text = "Sil";
            this.silSiparis.UseVisualStyleBackColor = false;
            this.silSiparis.Click += new System.EventHandler(this.silSiparis_Click);
            // 
            // guncelleSiparis
            // 
            this.guncelleSiparis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guncelleSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncelleSiparis.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.guncelleSiparis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelleSiparis.Location = new System.Drawing.Point(35, 521);
            this.guncelleSiparis.Name = "guncelleSiparis";
            this.guncelleSiparis.Size = new System.Drawing.Size(180, 85);
            this.guncelleSiparis.TabIndex = 29;
            this.guncelleSiparis.Text = "Güncelle";
            this.guncelleSiparis.UseVisualStyleBackColor = false;
            this.guncelleSiparis.Click += new System.EventHandler(this.guncelleSiparis_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(33, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 66);
            this.button4.TabIndex = 28;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // yemekEkle
            // 
            this.yemekEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yemekEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yemekEkle.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.yemekEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yemekEkle.Location = new System.Drawing.Point(267, 514);
            this.yemekEkle.Name = "yemekEkle";
            this.yemekEkle.Size = new System.Drawing.Size(180, 98);
            this.yemekEkle.TabIndex = 32;
            this.yemekEkle.Text = "Yemek Ekle";
            this.yemekEkle.UseVisualStyleBackColor = false;
            this.yemekEkle.Click += new System.EventHandler(this.yemekEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 42);
            this.label3.TabIndex = 33;
            this.label3.Text = "Masa No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 34;
            this.label1.Text = "Çalışan Bilgisi:";
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Location = new System.Drawing.Point(1131, 11);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(87, 68);
            this.cikis.TabIndex = 36;
            this.cikis.Text = "X";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yemekEkle);
            this.Controls.Add(this.ekleSiparis);
            this.Controls.Add(this.silSiparis);
            this.Controls.Add(this.guncelleSiparis);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmbCalisanID);
            this.Controls.Add(this.cmbMasaID);
            this.Controls.Add(this.dgvSiparisler);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.ComboBox cmbMasaID;
        private System.Windows.Forms.ComboBox cmbCalisanID;
        private System.Windows.Forms.Button ekleSiparis;
        private System.Windows.Forms.Button silSiparis;
        private System.Windows.Forms.Button guncelleSiparis;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button yemekEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikis;
    }
}