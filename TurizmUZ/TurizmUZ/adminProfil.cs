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
    public partial class adminProfil : Form
    {
        public adminProfil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("foydalanuvchilar.dat", FileMode.Open, FileAccess.Read));
            int pos = 0;
            br.BaseStream.Seek(pos, SeekOrigin.Begin);
            string[] f = new string[8];
            dataGridView1.Rows.Clear();
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                f[0] = br.ReadString();
                f[1] = br.ReadString();
                f[2] = br.ReadString();
                f[3] = br.ReadString();
                f[4] = br.ReadString();
                f[5] = br.ReadString();
                f[6] = br.ReadString();
                f[7] = br.ReadString();

                
                dataGridView1.Rows.Add(f[0], f[1], f[2], f[3], f[4], f[5],f[6],f[7]);


            }
            br.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("xodimlar.dat", FileMode.Open, FileAccess.Read));
            int pos = 0;
            br.BaseStream.Seek(pos, SeekOrigin.Begin);
            string[] f = new string[7];
            dataGridView1.Rows.Clear();
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                f[0] = br.ReadString();
                f[1] = br.ReadString();
                f[2] = br.ReadString();
                f[3] = br.ReadString();
                f[4] = br.ReadString();
                f[5] = br.ReadString();
                f[6] = br.ReadString();
                

                dataGridView2.Rows.Add(f[0], f[1], f[2], f[3], f[4], f[5], f[6]);


            }
            br.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HodimKiritish add = new HodimKiritish();
            add.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter a;
            a = File.AppendText("xabarlarbaza.txt");
            a.Write(textBox1.Text+"#__________________________________________#");
           
            a.Close();
            FileStream add = new FileStream("xabarlarbaza.txt", FileMode.Open);
            StreamReader ab = new StreamReader(add);
            
            string s = ab.ReadLine();
           

            richTextBox1.Text = s;
            add.Close();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
