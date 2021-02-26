using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TurizmUZ
{
    public partial class sozlamalar : UserControl
    {
        public sozlamalar()
        {
            InitializeComponent();
        }

        private void sozlamalar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("xodimlar.dat", FileMode.Open, FileAccess.Read));
            int pos = 0;
            br.BaseStream.Seek(pos, SeekOrigin.Begin);
            string[] f = new string[7];
            dataGridView2.Rows.Clear();
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
    }
}
