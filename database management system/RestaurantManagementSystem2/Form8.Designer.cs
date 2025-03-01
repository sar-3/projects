namespace RestaurantManagementSystem
{
    partial class Form8
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
            this.kategoriMalzemeButton = new System.Windows.Forms.Button();
            this.yemekButton = new System.Windows.Forms.Button();
            this.geriDon = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kategoriMalzemeButton
            // 
            this.kategoriMalzemeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kategoriMalzemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kategoriMalzemeButton.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.kategoriMalzemeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kategoriMalzemeButton.Location = new System.Drawing.Point(538, 234);
            this.kategoriMalzemeButton.Name = "kategoriMalzemeButton";
            this.kategoriMalzemeButton.Size = new System.Drawing.Size(300, 229);
            this.kategoriMalzemeButton.TabIndex = 1;
            this.kategoriMalzemeButton.Text = "Kategori ve Malzeme Bilgilerini Düzenle";
            this.kategoriMalzemeButton.UseVisualStyleBackColor = false;
            this.kategoriMalzemeButton.Click += new System.EventHandler(this.kategoriMalzemeButton_Click_1);
            // 
            // yemekButton
            // 
            this.yemekButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yemekButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yemekButton.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.yemekButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yemekButton.Location = new System.Drawing.Point(894, 234);
            this.yemekButton.Name = "yemekButton";
            this.yemekButton.Size = new System.Drawing.Size(300, 229);
            this.yemekButton.TabIndex = 3;
            this.yemekButton.Text = "Yemek  Bilgilerini Düzenle";
            this.yemekButton.UseVisualStyleBackColor = false;
            this.yemekButton.Click += new System.EventHandler(this.yemekButton_Click);
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geriDon.Font = new System.Drawing.Font("Gill Sans MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriDon.Location = new System.Drawing.Point(74, 37);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(70, 82);
            this.geriDon.TabIndex = 4;
            this.geriDon.Text = "<";
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Location = new System.Drawing.Point(1107, 43);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(87, 68);
            this.cikis.TabIndex = 36;
            this.cikis.Text = "X";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.yemekButton);
            this.Controls.Add(this.kategoriMalzemeButton);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kategoriMalzemeButton;
        private System.Windows.Forms.Button yemekButton;
        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.Button cikis;
    }
}