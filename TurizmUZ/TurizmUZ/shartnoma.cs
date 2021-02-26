using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TurizmUZ
{
    public partial class shartnoma : Form
    {
        public shartnoma()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void samarqand1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Naqd")
            {
                BinaryWriter bw = new BinaryWriter(new FileStream("foydalanuvchilar.dat", FileMode.Append, FileAccess.Write));
                bw.Write(textBox1.Text);
                bw.Write(textBox2.Text);
                bw.Write(textBox3.Text);
                bw.Write(maskedTextBox1.Text);
                bw.Write(ViloyatTanlash.vil);
                bw.Write(comboBox1.Text);
                bw.Write(dateTimePicker1.Text);
                bw.Write(textBox5.Text);
                bw.Close();
                MessageBox.Show("Xizmatlarimizdan foydalanganingiz uchun rahmat\nSayohatingiz maroqli o'tsin");
                this.Hide();
            }
            if(comboBox1.Text=="Pul Ko'chirish")
            {
                BinaryWriter bw = new BinaryWriter(new FileStream("foydalanuvchilar.dat", FileMode.Append, FileAccess.Write));
                bw.Write(textBox1.Text);
                bw.Write(textBox2.Text);
                bw.Write(textBox3.Text);
                bw.Write(maskedTextBox1.Text);
                bw.Write(ViloyatTanlash.vil);
                bw.Write(comboBox1.Text);
                bw.Write(dateTimePicker1.Text);
                bw.Write(textBox5.Text);
                bw.Close();
                MessageBox.Show("Bizning hisob raqamimiz\n8600130989470424\nXizmatlarimizdan foydalanganingiz uchun rahmat\nSayohatingiz maroqli o'tsin");
                this.Hide();
            }
        }

        private void shartnoma_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
