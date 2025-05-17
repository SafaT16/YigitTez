namespace WinFormsApp1
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            groupBox1 = new GroupBox();
            comboBox4 = new ComboBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox5 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(194, 64);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "B Grubu ";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.FromArgb(224, 224, 224);
            textBox3.Location = new Point(43, 255);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 24);
            textBox3.TabIndex = 3;
            textBox3.KeyDown += Form4_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(43, 204);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 24);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyDown += Form4_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.Location = new Point(53, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 24);
            textBox2.TabIndex = 2;
            textBox2.KeyDown += Form4_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(499, 64);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 3;
            label2.Text = "Belirlenen Skorlar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2025_01_03_2314071;
            pictureBox1.Location = new Point(37, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(620, 583);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "DEVAM";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(475, 471);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 17;
            label3.Text = "B Grubu Skoru =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(649, 471);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 18;
            label4.Text = "                                   ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 29);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(460, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 362);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox4.Location = new Point(189, 295);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(165, 28);
            comboBox4.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 143);
            label11.Name = "label11";
            label11.Size = new Size(168, 20);
            label11.TabIndex = 10;
            label11.Text = "Kollar destekleniyor mu:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox3.Location = new Point(189, 143);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(165, 28);
            comboBox3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 303);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 8;
            label8.Text = "Bilekte dönme var mı:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox2.Location = new Point(189, 109);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 28);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox1.Location = new Point(189, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 112);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 5;
            label7.Text = "Omuz yükseltilmiş mi: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 78);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 4;
            label6.Text = "Kolda dönme var mı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(475, 548);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 21;
            label9.Text = "Sonuç:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(543, 548);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 22;
            label10.Text = "...";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "İyi", "Orta", "Zayıf" });
            comboBox5.Location = new Point(649, 510);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(149, 28);
            comboBox5.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(620, 631);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 24;
            button1.Text = "İlerle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 672);
            Controls.Add(button1);
            Controls.Add(comboBox5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "B Grubu ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Label label4;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label10;
        private Label label9;
        private Label label11;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Button button1;
    }
}