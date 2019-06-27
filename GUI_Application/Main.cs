using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() !=System.Windows.Forms.DialogResult.Cancel)
            {
                
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawareapanel.Refresh();
            this.drawareapanel.backgroundImage = null;
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filter
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                PictureBox.image = new Bitmap(open.FileName);
                // image file path
                textBox1.Text = open.FileName;

            }
        }

        private void openTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StringReader OpenFile = new System.IO.StringReader(openFileDialog1.FileName);
            richTextBox1.Text = OpenFile.ReadToEnd();
            OpenFile.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btncmd_Click(object sender, EventArgs e)
        {
            Command_Based cb = new Command_Based();
            cb.Show();
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            GUI_Based gb = new GUI_Based();
            gb.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
