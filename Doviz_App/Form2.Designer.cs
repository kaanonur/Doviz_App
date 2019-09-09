namespace Doviz_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnEuroSat = new System.Windows.Forms.Button();
            this.btnEuroAl = new System.Windows.Forms.Button();
            this.btnDolarSat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.btnDolarAl = new System.Windows.Forms.Button();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecilenParaBirimi = new System.Windows.Forms.Label();
            this.btnDovizHesapla = new System.Windows.Forms.Button();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMusteridenAlinan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEuroSat
            // 
            this.btnEuroSat.Location = new System.Drawing.Point(350, 209);
            this.btnEuroSat.Name = "btnEuroSat";
            this.btnEuroSat.Size = new System.Drawing.Size(35, 34);
            this.btnEuroSat.TabIndex = 27;
            this.btnEuroSat.Text = ">";
            this.btnEuroSat.UseVisualStyleBackColor = true;
            this.btnEuroSat.Click += new System.EventHandler(this.btnEuroSat_Click);
            // 
            // btnEuroAl
            // 
            this.btnEuroAl.Location = new System.Drawing.Point(350, 169);
            this.btnEuroAl.Name = "btnEuroAl";
            this.btnEuroAl.Size = new System.Drawing.Size(35, 34);
            this.btnEuroAl.TabIndex = 26;
            this.btnEuroAl.Text = ">";
            this.btnEuroAl.UseVisualStyleBackColor = true;
            this.btnEuroAl.Click += new System.EventHandler(this.btnEuroAl_Click);
            // 
            // btnDolarSat
            // 
            this.btnDolarSat.Location = new System.Drawing.Point(350, 129);
            this.btnDolarSat.Name = "btnDolarSat";
            this.btnDolarSat.Size = new System.Drawing.Size(35, 34);
            this.btnDolarSat.TabIndex = 25;
            this.btnDolarSat.Text = ">";
            this.btnDolarSat.UseVisualStyleBackColor = true;
            this.btnDolarSat.Click += new System.EventHandler(this.btnDolarSat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtParaUstu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMusteridenAlinan);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.btnSatisYap);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Location = new System.Drawing.Point(440, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 350);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(198, 276);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(120, 35);
            this.btnHesapla.TabIndex = 20;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(343, 276);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(120, 35);
            this.btnSatisYap.TabIndex = 13;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(198, 227);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(265, 30);
            this.txtTutar.TabIndex = 18;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(198, 91);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(265, 30);
            this.txtMiktar.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(134, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tutar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(127, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Miktar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(149, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kur";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(198, 45);
            this.txtKur.Name = "txtKur";
            this.txtKur.ReadOnly = true;
            this.txtKur.Size = new System.Drawing.Size(265, 30);
            this.txtKur.TabIndex = 0;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // btnDolarAl
            // 
            this.btnDolarAl.Location = new System.Drawing.Point(350, 89);
            this.btnDolarAl.Name = "btnDolarAl";
            this.btnDolarAl.Size = new System.Drawing.Size(35, 34);
            this.btnDolarAl.TabIndex = 23;
            this.btnDolarAl.Text = ">";
            this.btnDolarAl.UseVisualStyleBackColor = true;
            this.btnDolarAl.Click += new System.EventHandler(this.btnDolarAl_Click);
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEuroSatis.Location = new System.Drawing.Point(245, 214);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(23, 25);
            this.lblEuroSatis.TabIndex = 22;
            this.lblEuroSatis.Text = "0";
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEuroAlis.Location = new System.Drawing.Point(245, 174);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(23, 25);
            this.lblEuroAlis.TabIndex = 21;
            this.lblEuroAlis.Text = "0";
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDolarSatis.Location = new System.Drawing.Point(245, 134);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(23, 25);
            this.lblDolarSatis.TabIndex = 20;
            this.lblDolarSatis.Text = "0";
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDolarAlis.Location = new System.Drawing.Point(245, 94);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(23, 25);
            this.lblDolarAlis.TabIndex = 19;
            this.lblDolarAlis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(126, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Euro Satış :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(138, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Euro Alış :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(121, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dolar Satış :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(133, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dolar Alış :";
            // 
            // lblSecilenParaBirimi
            // 
            this.lblSecilenParaBirimi.AutoSize = true;
            this.lblSecilenParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblSecilenParaBirimi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSecilenParaBirimi.Location = new System.Drawing.Point(185, 303);
            this.lblSecilenParaBirimi.Name = "lblSecilenParaBirimi";
            this.lblSecilenParaBirimi.Size = new System.Drawing.Size(118, 25);
            this.lblSecilenParaBirimi.TabIndex = 28;
            this.lblSecilenParaBirimi.Text = "SeçilenPara";
            this.lblSecilenParaBirimi.Visible = false;
            // 
            // btnDovizHesapla
            // 
            this.btnDovizHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDovizHesapla.Location = new System.Drawing.Point(143, 341);
            this.btnDovizHesapla.Name = "btnDovizHesapla";
            this.btnDovizHesapla.Size = new System.Drawing.Size(210, 55);
            this.btnDovizHesapla.TabIndex = 23;
            this.btnDovizHesapla.Text = "Döviz Hesapla";
            this.btnDovizHesapla.UseVisualStyleBackColor = true;
            this.btnDovizHesapla.Click += new System.EventHandler(this.btnDovizHesapla_Click);
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(198, 182);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.Size = new System.Drawing.Size(265, 30);
            this.txtParaUstu.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(94, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Para Üstü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(23, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Müşteriden Alınan";
            // 
            // txtMusteridenAlinan
            // 
            this.txtMusteridenAlinan.Location = new System.Drawing.Point(198, 136);
            this.txtMusteridenAlinan.Name = "txtMusteridenAlinan";
            this.txtMusteridenAlinan.Size = new System.Drawing.Size(265, 30);
            this.txtMusteridenAlinan.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1112, 632);
            this.Controls.Add(this.btnDovizHesapla);
            this.Controls.Add(this.lblSecilenParaBirimi);
            this.Controls.Add(this.btnEuroSat);
            this.Controls.Add(this.btnEuroAl);
            this.Controls.Add(this.btnDolarSat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDolarAl);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.lblDolarAlis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Döviz Satış";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEuroSat;
        private System.Windows.Forms.Button btnEuroAl;
        private System.Windows.Forms.Button btnDolarSat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Button btnDolarAl;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecilenParaBirimi;
        private System.Windows.Forms.Button btnDovizHesapla;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMusteridenAlinan;
    }
}