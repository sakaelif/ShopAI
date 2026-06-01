namespace ShopAI
{
    partial class AyakkabiForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnAsistanaBaglan = new System.Windows.Forms.Button();
            this.btnKategoriSecenegi = new System.Windows.Forms.Button();
            this.btnSepeteGit = new System.Windows.Forms.Button();
            this.lblAyakkabiSepetAdet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flpAyakkabiUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(535, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "AYAKKABI";
            // 
            // btnAsistanaBaglan
            // 
            this.btnAsistanaBaglan.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAsistanaBaglan.Location = new System.Drawing.Point(165, 21);
            this.btnAsistanaBaglan.Name = "btnAsistanaBaglan";
            this.btnAsistanaBaglan.Size = new System.Drawing.Size(122, 51);
            this.btnAsistanaBaglan.TabIndex = 11;
            this.btnAsistanaBaglan.Text = "Asistan ";
            this.btnAsistanaBaglan.UseVisualStyleBackColor = false;
            this.btnAsistanaBaglan.Click += new System.EventHandler(this.btnAsistanaBaglan_Click);
            // 
            // btnKategoriSecenegi
            // 
            this.btnKategoriSecenegi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKategoriSecenegi.Location = new System.Drawing.Point(31, 21);
            this.btnKategoriSecenegi.Name = "btnKategoriSecenegi";
            this.btnKategoriSecenegi.Size = new System.Drawing.Size(122, 51);
            this.btnKategoriSecenegi.TabIndex = 10;
            this.btnKategoriSecenegi.Text = "Diğer Kategoriler";
            this.btnKategoriSecenegi.UseVisualStyleBackColor = false;
            this.btnKategoriSecenegi.Click += new System.EventHandler(this.btnKategoriSecenegi_Click);
            // 
            // btnSepeteGit
            // 
            this.btnSepeteGit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSepeteGit.Location = new System.Drawing.Point(1216, 21);
            this.btnSepeteGit.Name = "btnSepeteGit";
            this.btnSepeteGit.Size = new System.Drawing.Size(122, 51);
            this.btnSepeteGit.TabIndex = 14;
            this.btnSepeteGit.Text = "Sepete Git ";
            this.btnSepeteGit.UseVisualStyleBackColor = false;
            this.btnSepeteGit.Click += new System.EventHandler(this.btnSepeteGit_Click);
            // 
            // lblAyakkabiSepetAdet
            // 
            this.lblAyakkabiSepetAdet.AutoSize = true;
            this.lblAyakkabiSepetAdet.Location = new System.Drawing.Point(1141, 38);
            this.lblAyakkabiSepetAdet.Name = "lblAyakkabiSepetAdet";
            this.lblAyakkabiSepetAdet.Size = new System.Drawing.Size(57, 16);
            this.lblAyakkabiSepetAdet.TabIndex = 12;
            this.lblAyakkabiSepetAdet.Text = "Toplam ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImage = global::ShopAI.Properties.Resources.pngtree_green_shopping_bag_with_cart_icon_png_image_16415711;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1066, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 51);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flpAyakkabiUrunler
            // 
            this.flpAyakkabiUrunler.AutoScroll = true;
            this.flpAyakkabiUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAyakkabiUrunler.Location = new System.Drawing.Point(0, 115);
            this.flpAyakkabiUrunler.Name = "flpAyakkabiUrunler";
            this.flpAyakkabiUrunler.Size = new System.Drawing.Size(1405, 583);
            this.flpAyakkabiUrunler.TabIndex = 15;
            // 
            // AyakkabiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopAI.Properties.Resources.SiparisOnayForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 698);
            this.Controls.Add(this.flpAyakkabiUrunler);
            this.Controls.Add(this.btnSepeteGit);
            this.Controls.Add(this.lblAyakkabiSepetAdet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsistanaBaglan);
            this.Controls.Add(this.btnKategoriSecenegi);
            this.Controls.Add(this.label6);
            this.Name = "AyakkabiForm";
            this.Text = "AyakkabıForm";
            this.Load += new System.EventHandler(this.AyakkabiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAsistanaBaglan;
        private System.Windows.Forms.Button btnKategoriSecenegi;
        private System.Windows.Forms.Button btnSepeteGit;
        private System.Windows.Forms.Label lblAyakkabiSepetAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpAyakkabiUrunler;
    }
}