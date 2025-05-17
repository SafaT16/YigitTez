using System.Windows.Forms;

namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            textGovdeSkor = new TextBox();
            textBoyunSkor = new TextBox();
            textBacakSkor = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            btnDevam = new Button();
            lblAGrubuSkoru = new Label();
            labelsonuc = new Label();
            pictureBox2 = new PictureBox();
            textboxAgirlik = new TextBox();
            groupBox1 = new GroupBox();
            labelPuan = new Label();
            label5 = new Label();
            CmbGuc = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            labelToplam = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2025_01_03_231429;
            pictureBox1.Location = new Point(23, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textGovdeSkor
            // 
            textGovdeSkor.Anchor = AnchorStyles.None;
            textGovdeSkor.BackColor = Color.FromArgb(224, 224, 224);
            textGovdeSkor.Location = new Point(49, 55);
            textGovdeSkor.Multiline = true;
            textGovdeSkor.Name = "textGovdeSkor";
            textGovdeSkor.Size = new Size(244, 24);
            textGovdeSkor.TabIndex = 0;
            textGovdeSkor.TextChanged += textBox1_TextChanged;
            // 
            // textBoyunSkor
            // 
            textBoyunSkor.Anchor = AnchorStyles.None;
            textBoyunSkor.BackColor = Color.FromArgb(224, 224, 224);
            textBoyunSkor.Location = new Point(49, 194);
            textBoyunSkor.Multiline = true;
            textBoyunSkor.Name = "textBoyunSkor";
            textBoyunSkor.Size = new Size(244, 23);
            textBoyunSkor.TabIndex = 1;
            textBoyunSkor.TextChanged += textBox2_TextChanged;
            // 
            // textBacakSkor
            // 
            textBacakSkor.Anchor = AnchorStyles.None;
            textBacakSkor.BackColor = Color.FromArgb(224, 224, 224);
            textBacakSkor.Location = new Point(49, 335);
            textBacakSkor.Multiline = true;
            textBacakSkor.Name = "textBacakSkor";
            textBacakSkor.Size = new Size(244, 23);
            textBacakSkor.TabIndex = 2;
            textBacakSkor.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(435, 74);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 8;
            label1.Text = "Belirlenen Skorlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(173, 63);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 10;
            label3.Text = "A Grubu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBoyunSkor, 0, 1);
            tableLayoutPanel1.Controls.Add(textGovdeSkor, 0, 0);
            tableLayoutPanel1.Controls.Add(textBacakSkor, 0, 2);
            tableLayoutPanel1.Location = new Point(476, 97);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.101265F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.898735F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(343, 416);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(881, 695);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "İleri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDevam
            // 
            btnDevam.BackColor = Color.FromArgb(128, 255, 128);
            btnDevam.Location = new Point(872, 641);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(94, 29);
            btnDevam.TabIndex = 15;
            btnDevam.Text = "DEVAM";
            btnDevam.UseVisualStyleBackColor = false;
            btnDevam.Click += btnDevam_Click_1;
            // 
            // lblAGrubuSkoru
            // 
            lblAGrubuSkoru.AutoSize = true;
            lblAGrubuSkoru.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAGrubuSkoru.Location = new Point(872, 541);
            lblAGrubuSkoru.Name = "lblAGrubuSkoru";
            lblAGrubuSkoru.Size = new Size(127, 20);
            lblAGrubuSkoru.TabIndex = 16;
            lblAGrubuSkoru.Text = "A Grubu Skoru =";
            // 
            // labelsonuc
            // 
            labelsonuc.AutoSize = true;
            labelsonuc.Location = new Point(1005, 541);
            labelsonuc.Name = "labelsonuc";
            labelsonuc.Size = new Size(18, 20);
            labelsonuc.TabIndex = 17;
            labelsonuc.Text = "...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 519);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(435, 85);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // textboxAgirlik
            // 
            textboxAgirlik.BackColor = Color.FromArgb(224, 224, 224);
            textboxAgirlik.Location = new Point(165, 22);
            textboxAgirlik.Name = "textboxAgirlik";
            textboxAgirlik.Size = new Size(125, 27);
            textboxAgirlik.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPuan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CmbGuc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textboxAgirlik);
            groupBox1.Location = new Point(479, 519);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 165);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // labelPuan
            // 
            labelPuan.AutoSize = true;
            labelPuan.Location = new Point(165, 122);
            labelPuan.Name = "labelPuan";
            labelPuan.Size = new Size(18, 20);
            labelPuan.TabIndex = 25;
            labelPuan.Text = "...";
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.Grip;
            label5.AutoSize = true;
            label5.Location = new Point(115, 122);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 24;
            label5.Text = "Puan:";
            // 
            // CmbGuc
            // 
            CmbGuc.BackColor = Color.FromArgb(224, 224, 224);
            CmbGuc.FormattingEnabled = true;
            CmbGuc.Items.AddRange(new object[] { "Evet", "Hayır" });
            CmbGuc.Location = new Point(165, 69);
            CmbGuc.Name = "CmbGuc";
            CmbGuc.Size = new Size(125, 28);
            CmbGuc.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 77);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 22;
            label4.Text = "Ani Güç Kullanıldı mı?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 21;
            label2.Text = "Ağırlık Giriniz:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(838, 584);
            label7.Name = "label7";
            label7.Size = new Size(161, 20);
            label7.TabIndex = 22;
            label7.Text = "Toplam A Grubu Skoru:";
            // 
            // labelToplam
            // 
            labelToplam.AutoSize = true;
            labelToplam.Location = new Point(1005, 584);
            labelToplam.Name = "labelToplam";
            labelToplam.Size = new Size(18, 20);
            labelToplam.TabIndex = 23;
            labelToplam.Text = "...";
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1336, 749);
            Controls.Add(labelToplam);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(labelsonuc);
            Controls.Add(lblAGrubuSkoru);
            Controls.Add(btnDevam);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "A Grubu";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoyunSkor;
        private TextBox textGovdeSkor;
        private TextBox textBacakSkor;
        private Button button1;
        private Button btnDevam;
        private Label lblAGrubuSkoru;
        private Label labelsonuc;
        private PictureBox pictureBox2;
        private TextBox textboxAgirlik;
        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private ComboBox CmbGuc;
        private Label labelPuan;
        private Label label5;
        private Label label7;
        private Label labelToplam;
    }
}