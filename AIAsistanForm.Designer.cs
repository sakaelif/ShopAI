namespace ShopAI
{
    partial class AIAsistanForm
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
            this.rtxtAiCevaplar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.rtxtMesajlar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtAiCevaplar
            // 
            this.rtxtAiCevaplar.Location = new System.Drawing.Point(24, 63);
            this.rtxtAiCevaplar.Name = "rtxtAiCevaplar";
            this.rtxtAiCevaplar.ReadOnly = true;
            this.rtxtAiCevaplar.Size = new System.Drawing.Size(610, 384);
            this.rtxtAiCevaplar.TabIndex = 0;
            this.rtxtAiCevaplar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(212, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHOPAI ASİSTAN";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGonder.Location = new System.Drawing.Point(482, 467);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(152, 42);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTemizle.Location = new System.Drawing.Point(482, 541);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(152, 42);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rtxtMesajlar
            // 
            this.rtxtMesajlar.Location = new System.Drawing.Point(26, 467);
            this.rtxtMesajlar.Name = "rtxtMesajlar";
            this.rtxtMesajlar.Size = new System.Drawing.Size(439, 116);
            this.rtxtMesajlar.TabIndex = 5;
            this.rtxtMesajlar.Text = "";
            // 
            // AIAsistanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopAI.Properties.Resources.SiparisOnayForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 621);
            this.Controls.Add(this.rtxtMesajlar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtAiCevaplar);
            this.Name = "AIAsistanForm";
            this.Text = "AI Asistan";
            this.Load += new System.EventHandler(this.AIAsistanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtAiCevaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.RichTextBox rtxtMesajlar;
    }
}