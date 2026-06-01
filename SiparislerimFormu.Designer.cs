namespace ShopAI
{
    partial class SiparislerimFormu
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
            this.dgvSiparislerim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparislerim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparislerim
            // 
            this.dgvSiparislerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparislerim.Location = new System.Drawing.Point(0, 1);
            this.dgvSiparislerim.Name = "dgvSiparislerim";
            this.dgvSiparislerim.RowHeadersWidth = 51;
            this.dgvSiparislerim.RowTemplate.Height = 24;
            this.dgvSiparislerim.Size = new System.Drawing.Size(1049, 569);
            this.dgvSiparislerim.TabIndex = 0;
            // 
            // SiparislerimFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 573);
            this.Controls.Add(this.dgvSiparislerim);
            this.Name = "SiparislerimFormu";
            this.Text = "Siparişerim Formu";
            this.Load += new System.EventHandler(this.SiparislerimFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparislerim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparislerim;
    }
}