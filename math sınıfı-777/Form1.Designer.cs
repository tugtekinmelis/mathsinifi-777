namespace math_sınıfı_777
{
    partial class Form1
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblKarekok = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblYuvarla = new System.Windows.Forms.Label();
            this.lblAsagi = new System.Windows.Forms.Label();
            this.lblYukari = new System.Windows.Forms.Label();
            this.lblMutlak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi.Location = new System.Drawing.Point(386, 68);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(171, 26);
            this.txtSayi.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(386, 111);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(171, 50);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblKarekok
            // 
            this.lblKarekok.AutoSize = true;
            this.lblKarekok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarekok.Location = new System.Drawing.Point(37, 36);
            this.lblKarekok.Name = "lblKarekok";
            this.lblKarekok.Size = new System.Drawing.Size(160, 18);
            this.lblKarekok.TabIndex = 2;
            this.lblKarekok.Text = "Karekök Hesaplama";
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUs.Location = new System.Drawing.Point(37, 72);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(71, 18);
            this.lblUs.TabIndex = 3;
            this.lblUs.Text = "Üs Alma";
            // 
            // lblYuvarla
            // 
            this.lblYuvarla.AutoSize = true;
            this.lblYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuvarla.Location = new System.Drawing.Point(37, 105);
            this.lblYuvarla.Name = "lblYuvarla";
            this.lblYuvarla.Size = new System.Drawing.Size(86, 18);
            this.lblYuvarla.TabIndex = 4;
            this.lblYuvarla.Text = "Yuvarlama";
            // 
            // lblAsagi
            // 
            this.lblAsagi.AutoSize = true;
            this.lblAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAsagi.Location = new System.Drawing.Point(37, 138);
            this.lblAsagi.Name = "lblAsagi";
            this.lblAsagi.Size = new System.Drawing.Size(132, 18);
            this.lblAsagi.TabIndex = 5;
            this.lblAsagi.Text = "Aşağı Yuvarlama";
            // 
            // lblYukari
            // 
            this.lblYukari.AutoSize = true;
            this.lblYukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukari.Location = new System.Drawing.Point(37, 170);
            this.lblYukari.Name = "lblYukari";
            this.lblYukari.Size = new System.Drawing.Size(138, 18);
            this.lblYukari.TabIndex = 6;
            this.lblYukari.Text = "Yukarı Yuvarlama";
            // 
            // lblMutlak
            // 
            this.lblMutlak.AutoSize = true;
            this.lblMutlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMutlak.Location = new System.Drawing.Point(37, 202);
            this.lblMutlak.Name = "lblMutlak";
            this.lblMutlak.Size = new System.Drawing.Size(108, 18);
            this.lblMutlak.TabIndex = 7;
            this.lblMutlak.Text = "Mutlak Değer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMutlak);
            this.Controls.Add(this.lblYukari);
            this.Controls.Add(this.lblAsagi);
            this.Controls.Add(this.lblYuvarla);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.lblKarekok);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblKarekok;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblYuvarla;
        private System.Windows.Forms.Label lblAsagi;
        private System.Windows.Forms.Label lblYukari;
        private System.Windows.Forms.Label lblMutlak;
    }
}

