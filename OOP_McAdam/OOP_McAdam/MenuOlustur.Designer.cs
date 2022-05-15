namespace OOP_McAdam
{
    partial class MenuOlustur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nudMenuFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuEkle);
            this.groupBox1.Controls.Add(this.nudMenuFiyat);
            this.groupBox1.Controls.Add(this.txtMenu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(199, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Bilgisi";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Location = new System.Drawing.Point(104, 179);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(144, 38);
            this.btnMenuEkle.TabIndex = 2;
            this.btnMenuEkle.Text = "Menu Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            // 
            // nudMenuFiyat
            // 
            this.nudMenuFiyat.Location = new System.Drawing.Point(104, 132);
            this.nudMenuFiyat.Name = "nudMenuFiyat";
            this.nudMenuFiyat.Size = new System.Drawing.Size(130, 30);
            this.nudMenuFiyat.TabIndex = 1;
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(104, 70);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(139, 30);
            this.txtMenu.TabIndex = 0;
            // 
            // MenuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuOlustur";
            this.Text = "MenuOlustur";
            this.Load += new System.EventHandler(this.MenuOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.NumericUpDown nudMenuFiyat;
        private System.Windows.Forms.TextBox txtMenu;
    }
}