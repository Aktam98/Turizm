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
    public partial class logpar : Form
    {
        public logpar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            FileStream add = new FileStream(@"E:\c#\Visual Studio 2013\Projects\TurizmUZ\TurizmUZ\bin\Debug\logpar.txt", FileMode.Truncate);
            StreamWriter a = new StreamWriter(add);
            a.Write(textBox4.Text + textBox3.Text);
            add.Close();
        }
    }
}
