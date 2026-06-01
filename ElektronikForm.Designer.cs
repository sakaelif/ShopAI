namespace ShopAI
{
    partial class ElektronikForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKategoriSecenegi = new System.Windows.Forms.Button();
            this.btnAsistanaBaglan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblElektronikSepetAdet = new System.Windows.Forms.Label();
            this.btnSepeteGit = new System.Windows.Forms.Button();
            this.flpEvVeYasamUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(556, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "ELEKTRONİK";
            // 
            // btnKategoriSecenegi
            // 
            this.btnKategoriSecenegi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKategoriSecenegi.Location = new System.Drawing.Point(8, 8);
            this.btnKategoriSecenegi.Name = "btnKategoriSecenegi";
            this.btnKategoriSecenegi.Size = new System.Drawing.Size(122, 51);
            this.btnKategoriSecenegi.TabIndex = 8;
            this.btnKategoriSecenegi.Text = "Diğer Kategoriler";
            this.btnKategoriSecenegi.UseVisualStyleBackColor = false;
            this.btnKategoriSecenegi.Click += new System.EventHandler(this.btnKategoriSecenegi_Click_1);
            // 
            // btnAsistanaBaglan
            // 
            this.btnAsistanaBaglan.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAsistanaBaglan.Location = new System.Drawing.Point(151, 8);
            this.btnAsistanaBaglan.Name = "btnAsistanaBaglan";
            this.btnAsistanaBaglan.Size = new System.Drawing.Size(122, 51);
            this.btnAsistanaBaglan.TabIndex = 9;
            this.btnAsistanaBaglan.Text = "Asistan ";
            this.btnAsistanaBaglan.UseVisualStyleBackColor = false;
            this.btnAsistanaBaglan.Click += new System.EventHandler(this.btnAsistanaBaglan_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImage = global::ShopAI.Properties.Resources.pngtree_green_shopping_bag_with_cart_icon_png_image_16415711;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(926, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 51);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblElektronikSepetAdet
            // 
            this.lblElektronikSepetAdet.AutoSize = true;
            this.lblElektronikSepetAdet.Location = new System.Drawing.Point(1002, 19);
            this.lblElektronikSepetAdet.Name = "lblElektronikSepetAdet";
            this.lblElektronikSepetAdet.Size = new System.Drawing.Size(57, 16);
            this.lblElektronikSepetAdet.TabIndex = 6;
            this.lblElektronikSepetAdet.Text = "Toplam ";
            // 
            // btnSepeteGit
            // 
            this.btnSepeteGit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSepeteGit.Location = new System.Drawing.Point(1076, 5);
            this.btnSepeteGit.Name = "btnSepeteGit";
            this.btnSepeteGit.Size = new System.Drawing.Size(122, 51);
            this.btnSepeteGit.TabIndex = 11;
            this.btnSepeteGit.Text = "Sepete Git";
            this.btnSepeteGit.UseVisualStyleBackColor = false;
            // 
            // flpEvVeYasamUrunler
            // 
            this.flpEvVeYasamUrunler.AllowDrop = true;
            this.flpEvVeYasamUrunler.AutoScroll = true;
            this.flpEvVeYasamUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpEvVeYasamUrunler.Location = new System.Drawing.Point(0, 89);
            this.flpEvVeYasamUrunler.Name = "flpEvVeYasamUrunler";
            this.flpEvVeYasamUrunler.Size = new System.Drawing.Size(1269, 715);
            this.flpEvVeYasamUrunler.TabIndex = 12;
            // 
            // ElektronikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopAI.Properties.Resources.SiparisOnayForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 804);
            this.Controls.Add(this.flpEvVeYasamUrunler);
            this.Controls.Add(this.btnSepeteGit);
            this.Controls.Add(this.lblElektronikSepetAdet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsistanaBaglan);
            this.Controls.Add(this.btnKategoriSecenegi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "ElektronikForm";
            this.Text = "Elektronik";
            this.Load += new System.EventHandler(this.ElektronikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKategoriSecenegi;
        private System.Windows.Forms.Button btnAsistanaBaglan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblElektronikSepetAdet;
        private System.Windows.Forms.Button btnSepeteGit;
        private System.Windows.Forms.FlowLayoutPanel flpEvVeYasamUrunler;
    }
}