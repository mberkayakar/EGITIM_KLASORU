using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKAR_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KAYIT BAŞARILI ");
            listBox1.Items.Add("İSİM : " + userControl11.textBox1.Text + "SOYİSİM : " + userControl11.textBox2.Text +
                ((userControl11.radioButton1.Checked) ? userControl11.radioButton1.Text : userControl11.radioButton2.Text) + " --- " + DateTime.Now.ToString());  
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.label1.Text = "DEGİSTİRİLMİS İSİM";
            userControl11.label2.Text = "DEGİSTİRİLMİS SOYİSİM";



        }
    }
}
