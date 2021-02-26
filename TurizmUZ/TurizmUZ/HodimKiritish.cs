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
    public partial class HodimKiritish : Form
    {
        public HodimKiritish()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HodimKiritish_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("xodimlar.dat", FileMode.Append, FileAccess.Write));
            bw.Write(textBox1.Text);
            bw.Write(textBox2.Text);
            bw.Write(textBox3.Text);
            bw.Write(comboBox1.Text);
            bw.Write(comboBox2.Text);
            bw.Write(comboBox3.Text);
            bw.Write(textBox4.Text);
           
            bw.Close();
            this.Hide();
        }
    }
}
