using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class rula : Form
    {
        public rula()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += taskType_CheckedChanged;
            radioButton2.CheckedChanged += taskType_CheckedChanged;
            radioButton3.CheckedChanged += taskType_CheckedChanged;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rula_Load(object sender, EventArgs e)
        {
            // Varsayılan iş tipi seçimi
            radioButton1.Checked = true;
            UpdateTaskDescription(); // Bu satır varsayılan açıklamayı ayarlar

            // Diğer başlangıç ayarları...

        }
        private void UpdateTaskDescription()
        {
            // İş tipi açıklamasını güncelle
            if (radioButton1.Checked)
            {
                label6.Text = "Hassas el işleri, montaj, yazma gibi işler için uygundur.";
            }
            else if (radioButton2.Checked)
            {
                label6.Text = "Paketleme, hafif montaj, klavye kullanımı gibi işler için uygundur.";
            }
            else if (radioButton3.Checked)
            {
                label6.Text = "Ağır malzemelerin taşınması, kaldırılması gibi işler için uygundur.";
            }
        }

   
        private void taskType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTaskDescription();
        }


        private void workerHeightTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        
    }
}
