namespace ShopAI
{
    partial class EvYasamForm
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
            this.lblEvVeYasamSepetAdet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flpEvYasamUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(508, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "EV VE YAŞAM";
            // 
            // btnAsistanaBaglan
            // 
            this.btnAsistanaBaglan.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAsistanaBaglan.Location = new System.Drawing.Point(136, 22);
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
            this.btnKategoriSecenegi.Location = new System.Drawing.Point(4, 22);
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
            this.btnSepeteGit.Location = new System.Drawing.Point(1182, 22);
            this.btnSepeteGit.Name = "btnSepeteGit";
            this.btnSepeteGit.Size = new System.Drawing.Size(122, 51);
            this.btnSepeteGit.TabIndex = 14;
            this.btnSepeteGit.Text = "Sepete Git";
            this.btnSepeteGit.UseVisualStyleBackColor = false;
            this.btnSepeteGit.Click += new System.EventHandler(this.btnSepeteGit_Click);
            // 
            // lblEvVeYasamSepetAdet
            // 
            this.lblEvVeYasamSepetAdet.AutoSize = true;
            this.lblEvVeYasamSepetAdet.Location = new System.Drawing.Point(1107, 39);
            this.lblEvVeYasamSepetAdet.Name = "lblEvVeYasamSepetAdet";
            this.lblEvVeYasamSepetAdet.Size = new System.Drawing.Size(57, 16);
            this.lblEvVeYasamSepetAdet.TabIndex = 12;
            this.lblEvVeYasamSepetAdet.Text = "Toplam ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImage = global::ShopAI.Properties.Resources.pngtree_green_shopping_bag_with_cart_icon_png_image_16415711;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1032, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 51);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flpEvYasamUrunler
            // 
            this.flpEvYasamUrunler.AllowDrop = true;
            this.flpEvYasamUrunler.AutoScroll = true;
            this.flpEvYasamUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpEvYasamUrunler.Location = new System.Drawing.Point(0, 114);
            this.flpEvYasamUrunler.Name = "flpEvYasamUrunler";
            this.flpEvYasamUrunler.Size = new System.Drawing.Size(1331, 538);
            this.flpEvYasamUrunler.TabIndex = 15;
            // 
            // EvYasamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ShopAI.Properties.Resources.SiparisOnayForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 652);
            this.Controls.Add(this.flpEvYasamUrunler);
            this.Controls.Add(this.btnSepeteGit);
            this.Controls.Add(this.lblEvVeYasamSepetAdet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsistanaBaglan);
            this.Controls.Add(this.btnKategoriSecenegi);
            this.Controls.Add(this.label6);
            this.Name = "EvYasamForm";
            this.Text = "Ev Ve Yaşam";
            this.Load += new System.EventHandler(this.EvYasamForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAsistanaBaglan;
        private System.Windows.Forms.Button btnKategoriSecenegi;
        private System.Windows.Forms.Button btnSepeteGit;
        private System.Windows.Forms.Label lblEvVeYasamSepetAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpEvYasamUrunler;
    }
}