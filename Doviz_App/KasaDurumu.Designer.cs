namespace Doviz_App
{
    partial class KasaDurumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaDurumu));
            this.btnTL = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTL
            // 
            this.btnTL.BackColor = System.Drawing.Color.Transparent;
            this.btnTL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTL.BackgroundImage")));
            this.btnTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTL.ForeColor = System.Drawing.Color.Transparent;
            this.btnTL.Location = new System.Drawing.Point(364, 148);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(464, 68);
            this.btnTL.TabIndex = 1;
            this.btnTL.Text = "₺";
            this.btnTL.UseVisualStyleBackColor = false;
            // 
            // btnDolar
            // 
            this.btnDolar.BackColor = System.Drawing.Color.Transparent;
            this.btnDolar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDolar.BackgroundImage")));
            this.btnDolar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDolar.ForeColor = System.Drawing.Color.Transparent;
            this.btnDolar.Location = new System.Drawing.Point(364, 261);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(464, 68);
            this.btnDolar.TabIndex = 2;
            this.btnDolar.Text = "€";
            this.btnDolar.UseVisualStyleBackColor = false;
            // 
            // btnEuro
            // 
            this.btnEuro.BackColor = System.Drawing.Color.Transparent;
            this.btnEuro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEuro.BackgroundImage")));
            this.btnEuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEuro.ForeColor = System.Drawing.Color.Transparent;
            this.btnEuro.Location = new System.Drawing.Point(364, 373);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(464, 68);
            this.btnEuro.TabIndex = 3;
            this.btnEuro.Text = "$";
            this.btnEuro.UseVisualStyleBackColor = false;
            // 
            // KasaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnTL);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KasaDurumu";
            this.Text = "KasaDurumu";
            this.Load += new System.EventHandler(this.KasaDurumu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnEuro;
    }
}