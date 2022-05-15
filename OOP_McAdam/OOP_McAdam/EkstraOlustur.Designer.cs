namespace OOP_McAdam
{
    partial class EkstraOlustur
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
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.nudEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkstraEkle);
            this.groupBox1.Controls.Add(this.nudEkstraFiyat);
            this.groupBox1.Controls.Add(this.txtEkstra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(63, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra Bilgiler";
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(104, 179);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(144, 38);
            this.btnEkstraEkle.TabIndex = 2;
            this.btnEkstraEkle.Text = "Ekstra Ekle";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            // 
            // nudEkstraFiyat
            // 
            this.nudEkstraFiyat.Location = new System.Drawing.Point(104, 132);
            this.nudEkstraFiyat.Name = "nudEkstraFiyat";
            this.nudEkstraFiyat.Size = new System.Drawing.Size(130, 30);
            this.nudEkstraFiyat.TabIndex = 1;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(104, 70);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(139, 30);
            this.txtEkstra.TabIndex = 0;
            // 
            // EkstraOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "EkstraOlustur";
            this.Text = "EkstraOlustur";
            this.Load += new System.EventHandler(this.EkstraOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkstraEkle;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyat;
        private System.Windows.Forms.TextBox txtEkstra;
    }
}