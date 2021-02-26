using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurizmUZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            viloyat1.Hide();
            malumot1.Hide();
            sozlamalar1.Hide();
            home1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            malumot1.Hide();
            viloyat1.Hide();
            sozlamalar1.Hide();
            home1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            malumot1.Hide();
            home1.Hide();
            sozlamalar1.Hide();
            viloyat1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home1.Hide();
            viloyat1.Hide();
            sozlamalar1.Hide();
            malumot1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mybooking.uz");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin add = new admin();
            add.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            chiqish add = new chiqish();
            add.Show();
           
        }

        private void narx1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://facebook.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://twitter.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://instagram.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://1aviakassa.uz/raspisanie-aviarejsov");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            home1.Hide();
            viloyat1.Hide();

            malumot1.Hide();
            sozlamalar1.Show();
        }
    }
}
