using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixerBoja
{
    public partial class Form1 : Form
    {
        int c, z, p;

        private void Crvena_Scroll(object sender, EventArgs e)
        {
            PromjeniBoju();
        }

        private void Zelena_Scroll(object sender, EventArgs e)
        {
            PromjeniBoju();
        }

        private void Plava_Scroll(object sender, EventArgs e)
        {
            PromjeniBoju();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.Cursor = Cursors.Hand;
        //}

        public Form1()
        {
            InitializeComponent();
        }
        private void PromjeniBoju()
        {
            c = Crvena.Value;
            z = Zelena.Value;
            p = Plava.Value;

            pictureBox1.BackColor = Color.FromArgb(c, z, p);
        }
    }
}
