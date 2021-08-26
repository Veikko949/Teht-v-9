namespace AUTO
{
    partial class Form1
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
            this.kilometritV_comboBox = new System.Windows.Forms.ComboBox();
            this.laina_textBox = new System.Windows.Forms.TextBox();
            this.nesteet_textBox = new System.Windows.Forms.TextBox();
            this.vakuutus_textBox = new System.Windows.Forms.TextBox();
            this.poltoaine_textBox = new System.Windows.Forms.TextBox();
            this.muutkulut_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vastaus_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.renkaat_textBox = new System.Windows.Forms.TextBox();
            this.huollot_textBox = new System.Windows.Forms.TextBox();
            this.pesut_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kilometritV_comboBox
            // 
            this.kilometritV_comboBox.FormattingEnabled = true;
            this.kilometritV_comboBox.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500",
            "5000",
            "5500",
            "6000",
            "6500",
            "7000",
            "7500",
            "8000",
            "8500",
            "9000",
            "9500",
            "10000"});
            this.kilometritV_comboBox.Location = new System.Drawing.Point(410, 170);
            this.kilometritV_comboBox.Name = "kilometritV_comboBox";
            this.kilometritV_comboBox.Size = new System.Drawing.Size(121, 21);
            this.kilometritV_comboBox.TabIndex = 0;
            this.kilometritV_comboBox.SelectedIndexChanged += new System.EventHandler(this.kilometritV_comboBox_SelectedIndexChanged);
            // 
            // laina_textBox
            // 
            this.laina_textBox.Location = new System.Drawing.Point(175, 47);
            this.laina_textBox.Name = "laina_textBox";
            this.laina_textBox.Size = new System.Drawing.Size(121, 20);
            this.laina_textBox.TabIndex = 1;
            // 
            // nesteet_textBox
            // 
            this.nesteet_textBox.Location = new System.Drawing.Point(175, 87);
            this.nesteet_textBox.Name = "nesteet_textBox";
            this.nesteet_textBox.Size = new System.Drawing.Size(121, 20);
            this.nesteet_textBox.TabIndex = 2;
            // 
            // vakuutus_textBox
            // 
            this.vakuutus_textBox.Location = new System.Drawing.Point(175, 129);
            this.vakuutus_textBox.Name = "vakuutus_textBox";
            this.vakuutus_textBox.Size = new System.Drawing.Size(121, 20);
            this.vakuutus_textBox.TabIndex = 3;
            // 
            // poltoaine_textBox
            // 
            this.poltoaine_textBox.Location = new System.Drawing.Point(175, 207);
            this.poltoaine_textBox.Name = "poltoaine_textBox";
            this.poltoaine_textBox.Size = new System.Drawing.Size(121, 20);
            this.poltoaine_textBox.TabIndex = 5;
            // 
            // muutkulut_textBox
            // 
            this.muutkulut_textBox.Location = new System.Drawing.Point(175, 167);
            this.muutkulut_textBox.Name = "muutkulut_textBox";
            this.muutkulut_textBox.Size = new System.Drawing.Size(121, 20);
            this.muutkulut_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Laina lyhenys korkoineen:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vakuutusmaksut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Muut kulut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Polttoneste:";
            // 
            // vastaus_label
            // 
            this.vastaus_label.AutoSize = true;
            this.vastaus_label.Location = new System.Drawing.Point(42, 252);
            this.vastaus_label.Name = "vastaus_label";
            this.vastaus_label.Size = new System.Drawing.Size(14, 13);
            this.vastaus_label.TabIndex = 18;
            this.vastaus_label.Text = "X";
            this.vastaus_label.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kilometrit/vuosi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Renkaat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Huollot:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Peust:";
            // 
            // renkaat_textBox
            // 
            this.renkaat_textBox.Location = new System.Drawing.Point(410, 132);
            this.renkaat_textBox.Name = "renkaat_textBox";
            this.renkaat_textBox.Size = new System.Drawing.Size(121, 20);
            this.renkaat_textBox.TabIndex = 21;
            // 
            // huollot_textBox
            // 
            this.huollot_textBox.Location = new System.Drawing.Point(410, 90);
            this.huollot_textBox.Name = "huollot_textBox";
            this.huollot_textBox.Size = new System.Drawing.Size(121, 20);
            this.huollot_textBox.TabIndex = 20;
            // 
            // pesut_textBox
            // 
            this.pesut_textBox.Location = new System.Drawing.Point(410, 47);
            this.pesut_textBox.Name = "pesut_textBox";
            this.pesut_textBox.Size = new System.Drawing.Size(121, 20);
            this.pesut_textBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 336);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.renkaat_textBox);
            this.Controls.Add(this.huollot_textBox);
            this.Controls.Add(this.pesut_textBox);
            this.Controls.Add(this.vastaus_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poltoaine_textBox);
            this.Controls.Add(this.muutkulut_textBox);
            this.Controls.Add(this.vakuutus_textBox);
            this.Controls.Add(this.nesteet_textBox);
            this.Controls.Add(this.laina_textBox);
            this.Controls.Add(this.kilometritV_comboBox);
            this.Name = "Form1";
            this.Text = "Auton kulujen laskeminen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kilometritV_comboBox;
        private System.Windows.Forms.TextBox laina_textBox;
        private System.Windows.Forms.TextBox nesteet_textBox;
        private System.Windows.Forms.TextBox vakuutus_textBox;
        private System.Windows.Forms.TextBox poltoaine_textBox;
        private System.Windows.Forms.TextBox muutkulut_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label vastaus_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox renkaat_textBox;
        private System.Windows.Forms.TextBox huollot_textBox;
        private System.Windows.Forms.TextBox pesut_textBox;
    }
}

