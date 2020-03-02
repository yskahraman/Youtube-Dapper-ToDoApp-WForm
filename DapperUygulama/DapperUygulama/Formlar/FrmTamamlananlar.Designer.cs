namespace DapperUygulama.Formlar
{
    partial class FrmTamamlananlar
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
            this.dataGridTamamlanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTamamlanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTamamlanan
            // 
            this.dataGridTamamlanan.AllowUserToAddRows = false;
            this.dataGridTamamlanan.AllowUserToDeleteRows = false;
            this.dataGridTamamlanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTamamlanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTamamlanan.Location = new System.Drawing.Point(0, 0);
            this.dataGridTamamlanan.Name = "dataGridTamamlanan";
            this.dataGridTamamlanan.ReadOnly = true;
            this.dataGridTamamlanan.Size = new System.Drawing.Size(617, 322);
            this.dataGridTamamlanan.TabIndex = 0;
            // 
            // FrmTamamlananlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 322);
            this.Controls.Add(this.dataGridTamamlanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTamamlananlar";
            this.Text = "FrmTamamlananlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTamamlanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTamamlanan;
    }
}