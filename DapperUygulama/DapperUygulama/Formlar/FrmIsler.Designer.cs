namespace DapperUygulama.Formlar
{
    partial class FrmIsler
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTamamlananlar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBekleyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(12, 346);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(142, 23);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnTamamlananlar
            // 
            this.btnTamamlananlar.Location = new System.Drawing.Point(12, 57);
            this.btnTamamlananlar.Name = "btnTamamlananlar";
            this.btnTamamlananlar.Size = new System.Drawing.Size(142, 23);
            this.btnTamamlananlar.TabIndex = 0;
            this.btnTamamlananlar.Text = "Tamamlananlar";
            this.btnTamamlananlar.UseVisualStyleBackColor = true;
            this.btnTamamlananlar.Click += new System.EventHandler(this.btnTamamlananlar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(177, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 341);
            this.panel1.TabIndex = 1;
            // 
            // btnBekleyen
            // 
            this.btnBekleyen.Location = new System.Drawing.Point(12, 28);
            this.btnBekleyen.Name = "btnBekleyen";
            this.btnBekleyen.Size = new System.Drawing.Size(142, 23);
            this.btnBekleyen.TabIndex = 0;
            this.btnBekleyen.Text = "Bekleyenler";
            this.btnBekleyen.UseVisualStyleBackColor = true;
            this.btnBekleyen.Click += new System.EventHandler(this.btnBekleyen_Click);
            // 
            // FrmIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTamamlananlar);
            this.Controls.Add(this.btnBekleyen);
            this.Controls.Add(this.btnKapat);
            this.Name = "FrmIsler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIsler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIsler_FormClosed);
            this.Load += new System.EventHandler(this.FrmIsler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnTamamlananlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBekleyen;
    }
}