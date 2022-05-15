namespace WFA_KiminKonusu
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
            this.btnSec = new System.Windows.Forms.Button();
            this.lstKonu = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOYAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KONU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LstSinifListesi = new System.Windows.Forms.ListBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(527, 513);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(241, 60);
            this.btnSec.TabIndex = 8;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // lstKonu
            // 
            this.lstKonu.FormattingEnabled = true;
            this.lstKonu.ItemHeight = 16;
            this.lstKonu.Location = new System.Drawing.Point(962, 20);
            this.lstKonu.Name = "lstKonu";
            this.lstKonu.Size = new System.Drawing.Size(323, 468);
            this.lstKonu.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AD,
            this.SOYAD,
            this.KONU,
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(306, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(650, 467);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // AD
            // 
            this.AD.Text = "AD";
            this.AD.Width = 147;
            // 
            // SOYAD
            // 
            this.SOYAD.Text = "SOYAD";
            this.SOYAD.Width = 185;
            // 
            // KONU
            // 
            this.KONU.Text = "KONU";
            this.KONU.Width = 207;
            // 
            // LstSinifListesi
            // 
            this.LstSinifListesi.FormattingEnabled = true;
            this.LstSinifListesi.ItemHeight = 16;
            this.LstSinifListesi.Location = new System.Drawing.Point(12, 20);
            this.LstSinifListesi.Name = "LstSinifListesi";
            this.LstSinifListesi.Size = new System.Drawing.Size(288, 468);
            this.LstSinifListesi.TabIndex = 4;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Puan";
            this.columnHeader1.Width = 106;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 597);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lstKonu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LstSinifListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ListBox lstKonu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader AD;
        private System.Windows.Forms.ColumnHeader SOYAD;
        private System.Windows.Forms.ColumnHeader KONU;
        private System.Windows.Forms.ListBox LstSinifListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

