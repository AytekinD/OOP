namespace _12_SiparisOtomasyonu.Entities.Forms
{
    partial class FrmExtra
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
            this.btnExtraEkle = new System.Windows.Forms.Button();
            this.numericUpDownExtraFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblMenuFiyat = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtraEkle
            // 
            this.btnExtraEkle.Location = new System.Drawing.Point(163, 102);
            this.btnExtraEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExtraEkle.Name = "btnExtraEkle";
            this.btnExtraEkle.Size = new System.Drawing.Size(88, 23);
            this.btnExtraEkle.TabIndex = 9;
            this.btnExtraEkle.Text = "Ekle";
            this.btnExtraEkle.UseVisualStyleBackColor = true;
            // 
            // numericUpDownExtraFiyat
            // 
            this.numericUpDownExtraFiyat.Location = new System.Drawing.Point(111, 54);
            this.numericUpDownExtraFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownExtraFiyat.Name = "numericUpDownExtraFiyat";
            this.numericUpDownExtraFiyat.Size = new System.Drawing.Size(140, 20);
            this.numericUpDownExtraFiyat.TabIndex = 8;
            // 
            // lblMenuFiyat
            // 
            this.lblMenuFiyat.AutoSize = true;
            this.lblMenuFiyat.Location = new System.Drawing.Point(15, 56);
            this.lblMenuFiyat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMenuFiyat.Name = "lblMenuFiyat";
            this.lblMenuFiyat.Size = new System.Drawing.Size(72, 13);
            this.lblMenuFiyat.TabIndex = 7;
            this.lblMenuFiyat.Text = "Menu Fiyati";
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(111, 17);
            this.txtMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(139, 20);
            this.txtMenu.TabIndex = 6;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(15, 20);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(58, 13);
            this.lblExtra.TabIndex = 5;
            this.lblExtra.Text = "Extra Adi";
            // 
            // FrmExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 201);
            this.Controls.Add(this.btnExtraEkle);
            this.Controls.Add(this.numericUpDownExtraFiyat);
            this.Controls.Add(this.lblMenuFiyat);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.lblExtra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmExtra";
            this.Text = "FrmExtra";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtraFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtraEkle;
        private System.Windows.Forms.NumericUpDown numericUpDownExtraFiyat;
        private System.Windows.Forms.Label lblMenuFiyat;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label lblExtra;
    }
}