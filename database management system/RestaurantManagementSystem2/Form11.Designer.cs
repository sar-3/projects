namespace RestaurantManagementSystem
{
    partial class Form11
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
            this.ekleVardiya = new System.Windows.Forms.Button();
            this.guncelleVardiya = new System.Windows.Forms.Button();
            this.silVardiya = new System.Windows.Forms.Button();
            this.geriDon = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbCalisanId = new System.Windows.Forms.ComboBox();
            this.dataGridViewVardiya = new System.Windows.Forms.DataGridView();
            this.cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVardiya)).BeginInit();
            this.SuspendLayout();
            // 
            // ekleVardiya
            // 
            this.ekleVardiya.BackColor = System.Drawing.SystemColors.ControlText;
            this.ekleVardiya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekleVardiya.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleVardiya.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekleVardiya.Location = new System.Drawing.Point(57, 398);
            this.ekleVardiya.Name = "ekleVardiya";
            this.ekleVardiya.Size = new System.Drawing.Size(200, 80);
            this.ekleVardiya.TabIndex = 2;
            this.ekleVardiya.Text = "Ekle";
            this.ekleVardiya.UseVisualStyleBackColor = false;
            this.ekleVardiya.Click += new System.EventHandler(this.ekleVardiya_Click);
            // 
            // guncelleVardiya
            // 
            this.guncelleVardiya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncelleVardiya.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.guncelleVardiya.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelleVardiya.Location = new System.Drawing.Point(167, 484);
            this.guncelleVardiya.Name = "guncelleVardiya";
            this.guncelleVardiya.Size = new System.Drawing.Size(200, 80);
            this.guncelleVardiya.TabIndex = 3;
            this.guncelleVardiya.Text = "Güncelle";
            this.guncelleVardiya.UseVisualStyleBackColor = true;
            this.guncelleVardiya.Click += new System.EventHandler(this.guncelleVardiya_Click);
            // 
            // silVardiya
            // 
            this.silVardiya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.silVardiya.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.silVardiya.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silVardiya.Location = new System.Drawing.Point(275, 398);
            this.silVardiya.Name = "silVardiya";
            this.silVardiya.Size = new System.Drawing.Size(200, 80);
            this.silVardiya.TabIndex = 4;
            this.silVardiya.Text = "Sil";
            this.silVardiya.UseVisualStyleBackColor = true;
            this.silVardiya.Click += new System.EventHandler(this.silVardiya_Click);
            // 
            // geriDon
            // 
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geriDon.Font = new System.Drawing.Font("Gill Sans MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriDon.Location = new System.Drawing.Point(53, 37);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(73, 66);
            this.geriDon.TabIndex = 5;
            this.geriDon.Text = "<";
            this.geriDon.UseVisualStyleBackColor = true;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(91, 287);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(338, 34);
            this.dtpTarih.TabIndex = 13;
            // 
            // cmbCalisanId
            // 
            this.cmbCalisanId.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbCalisanId.FormattingEnabled = true;
            this.cmbCalisanId.Location = new System.Drawing.Point(91, 219);
            this.cmbCalisanId.Name = "cmbCalisanId";
            this.cmbCalisanId.Size = new System.Drawing.Size(338, 41);
            this.cmbCalisanId.TabIndex = 21;
            this.cmbCalisanId.Text = "Çalışan No Seçin...";
            // 
            // dataGridViewVardiya
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DeepPink;
            this.dataGridViewVardiya.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewVardiya.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVardiya.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewVardiya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVardiya.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewVardiya.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewVardiya.Location = new System.Drawing.Point(503, 139);
            this.dataGridViewVardiya.Name = "dataGridViewVardiya";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVardiya.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewVardiya.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DeepPink;
            this.dataGridViewVardiya.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewVardiya.RowTemplate.Height = 24;
            this.dataGridViewVardiya.Size = new System.Drawing.Size(730, 480);
            this.dataGridViewVardiya.TabIndex = 22;
            this.dataGridViewVardiya.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVardiya_CellClick);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Location = new System.Drawing.Point(1146, 35);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(87, 68);
            this.cikis.TabIndex = 36;
            this.cikis.Text = "X";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.dataGridViewVardiya);
            this.Controls.Add(this.cmbCalisanId);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.silVardiya);
            this.Controls.Add(this.guncelleVardiya);
            this.Controls.Add(this.ekleVardiya);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVardiya)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekleVardiya;
        private System.Windows.Forms.Button guncelleVardiya;
        private System.Windows.Forms.Button silVardiya;
        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbCalisanId;
        private System.Windows.Forms.DataGridView dataGridViewVardiya;
        private System.Windows.Forms.Button cikis;
    }
}