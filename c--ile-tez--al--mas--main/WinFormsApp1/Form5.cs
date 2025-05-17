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

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public string sayi1;
        public string sayi2;
        public Form5()
        {
            InitializeComponent();         
        }

        

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = sayi1;
            label2.Text = sayi2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rebaA = int.Parse(label1.Text);
            int rebaB = int.Parse(label2.Text);

            // REBA C matrisini tanımla
            int[,] CMatrix = new int[,]
            {
        { 1, 2, 3, 3, 4, 4, 5, 6, 7, 7, 8, 8 },
        { 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8 },
        { 3, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9 },
        { 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9, 9 },
        { 4, 4, 5, 6, 6, 7, 8, 8, 9, 9,10,10 },
        { 5, 5, 6, 6, 7, 8, 8, 9, 9,10,10,11 },
        { 6, 6, 7, 8, 8, 9, 9,10,10,11,11,12 },
        { 7, 7, 8, 8, 9, 9,10,10,11,11,12,12 },
        { 8, 8, 9, 9,10,10,11,11,12,12,12,12 },
        { 9, 9,10,10,11,11,12,12,12,12,12,12 },
        {10,10,11,11,12,12,12,12,12,12,12,12 },
        {12,12,12,12,12,12,12,12,12,12,12,12 }
            };

            // Dizideki indexler 0'dan başladığı için -1
            int aIndex = rebaA - 1;
            int bIndex = rebaB - 1;

            // Skorları kontrol et
            if (aIndex >= 0 && aIndex < 12 && bIndex >= 0 && bIndex < 12)
            {
                int rebaC = CMatrix[aIndex, bIndex];
                label3.Text =  rebaC.ToString();
            }
            else
            {
                label3.Text = "Geçersiz A veya B skoru!";
            }
        }
    }
}
