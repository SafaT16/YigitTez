using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{

    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Buraya metin değiştiğinde yapılacak işlemleri yazabilirsiniz.
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDevam_Click_1(object sender, EventArgs e)
        {
            int yukSkoru = 0;

            try
            {
                double agirlik = double.Parse(textboxAgirlik.Text); // kilogram cinsinden değer

                // Ağırlığa göre puanlama
                if (agirlik < 5)
                    yukSkoru = 0;
                else if (agirlik >= 5 && agirlik <= 10)
                    yukSkoru = 1;
                else // agirlik > 10
                    yukSkoru = 2;

                // ComboBox kontrolü: Evet ise +1 puan
                if (CmbGuc.SelectedItem != null && CmbGuc.SelectedItem.ToString() == "Evet")
                {
                    yukSkoru += 1;
                }

                labelPuan.Text = "Yük Skoru: " + yukSkoru.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir ağırlık değeri giriniz.");
            }


            // 3B REBA skor tablosu: [boyun, bacak, govde]
            int[,,] tablo = new int[3, 4, 5]
            {
        // Boyun 1
        {
            { 1,2,2,3,4},  // Bacak 1
            { 2,3,4,5,6 },  // Bacak 2
            { 3, 4, 5, 6, 7 },  // Bacak 3
            { 4, 5, 6, 7, 8 }   // Bacak 4
        },

        // Boyun 2
        {
            { 1,3,4,5,6 },
            { 2,4,5,6,7},
            { 3,5,6,7,8},
            { 4, 6, 7, 8, 9 }
        },

        // Boyun 3
        {
            { 3, 4, 5, 6, 7 },
            { 3, 5, 6, 7, 8 },
            { 5, 6, 7, 8, 9 },
            { 6, 7, 8, 9, 9 }
        }
            };

            try
            {
                int boyun = int.Parse(textGovdeSkor.Text);   // 1–3
                int bacak = int.Parse(textBoyunSkor.Text);   // 1–4
                int govde = int.Parse(textBacakSkor.Text);   // 1–5

                int boyunIndex = boyun - 1;
                int bacakIndex = bacak - 1;
                int govdeIndex = govde - 1;

                if (boyunIndex < 0 || boyunIndex > 2 || bacakIndex < 0 || bacakIndex > 3 || govdeIndex < 0 || govdeIndex > 4)
                {
                    MessageBox.Show("Lütfen geçerli aralıkta değerler giriniz:\nBoyun: 1–3\nBacak: 1–4\nGövde: 1–5");
                    return;
                }

                int skor = tablo[boyunIndex, bacakIndex, govdeIndex];
                labelsonuc.Text = "A Grubu Skoru: " + skor.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen tüm alanlara sayısal değerler giriniz.");
            }
            try
            {
                // label4 ve label5'teki metinlerden sayısal değerleri çek
                int skor1 = int.Parse(labelPuan.Text.Split(':').Last().Trim());
                int skor2 = int.Parse(labelsonuc.Text.Split(':').Last().Trim());

                // Toplamı hesapla
                int toplamSkor = skor1 + skor2;

                // label6'ya yaz
                labelToplam.Text =  toplamSkor.ToString();
            }
            catch
            {
                MessageBox.Show("Label değerleri uygun formatta değil veya boş olabilir.");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Form2'nin bir örneğini oluştur
            form4.sayi2=labelToplam.Text;
            form4.Show(); // Form2'yi göster
            this.Hide();  // İsteğe bağlı: Form1'i gizle (kapatmaz)
            string deger1 = labelToplam.Text; // Form1'deki label değeri
        }
    }
}

