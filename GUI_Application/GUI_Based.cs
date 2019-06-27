using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI_Application
{
    public partial class GUI_Based : Form
    {
        public GUI_Based()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            texturestyle = 0;
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            paintcolor = c.Color;

            showcolorbox.BackColor = paintcolor;
            p.Color = c.Color;
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            selectshape = 1;
        }
    }
}
