namespace DapperUygulama.Formlar
{
    partial class FrmBekleyenler
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
            this.dataGridBekleyen = new System.Windows.Forms.DataGridView();
            this.btnYeniIs = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBekleyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBekleyen
            // 
            this.dataGridBekleyen.AllowUserToAddRows = false;
            this.dataGridBekleyen.AllowUserToDeleteRows = false;
            this.dataGridBekleyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBekleyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridBekleyen.Location = new System.Drawing.Point(0, 0);
            this.dataGridBekleyen.Name = "dataGridBekleyen";
            this.dataGridBekleyen.ReadOnly = true;
            this.dataGridBekleyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBekleyen.Size = new System.Drawing.Size(537, 234);
            this.dataGridBekleyen.TabIndex = 0;
            this.dataGridBekleyen.Click += new System.EventHandler(this.dataGridBekleyen_Click);
            // 
            // btnYeniIs
            // 
            this.btnYeniIs.Location = new System.Drawing.Point(122, 255);
            this.btnYeniIs.Name = "btnYeniIs";
            this.btnYeniIs.Size = new System.Drawing.Size(173, 23);
            this.btnYeniIs.TabIndex = 1;
            this.btnYeniIs.Text = "Yeni İş Ekle";
            this.btnYeniIs.UseVisualStyleBackColor = true;
            this.btnYeniIs.Click += new System.EventHandler(this.btnYeniIs_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(301, 255);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(173, 23);
            this.btnTamamla.TabIndex = 1;
            this.btnTamamla.Text = "Tamamla !";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // FrmBekleyenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 300);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnYeniIs);
            this.Controls.Add(this.dataGridBekleyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBekleyenler";
            this.Text = "FrmBekleyenler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBekleyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBekleyen;
        private System.Windows.Forms.Button btnYeniIs;
        private System.Windows.Forms.Button btnTamamla;
    }
}