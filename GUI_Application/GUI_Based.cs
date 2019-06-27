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
using System.Text.RegularExpressions;

namespace GUI_Application
{
    public partial class GUI_Based : Form
    {
        private bool mousedown;
        private Point lastlocation;
        int texturestyle = 0;

        int selectshape = 0;

        /// <summary>
        /// for color dialog box
        /// </summary>
        Color paintcolor = Color.Black;

        Graphics g;
        Pen p;
        Brush bb;
        int x, y = 0;
        int x1, y1, x2, y2 = 0;

        private void btn_square_Click(object sender, EventArgs e)
        {
           // selectshape = 3;
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
           // selectshape = 4;
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
           // selectshape = 5;
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
           // selectshape = 6;
        }

        private void drawareapanel_Paint(object sender, PaintEventArgs e)
        {
            lbl_cursorx.Text = e.X.ToString();
            lbl_cursory.Text = e.Y.ToString();
            if (start)
            {
                if (selectshape == 1)
                {
                    if (x > 0 && y > 00)
                    {
                        g.DrawLine(p, x, y, e.X, e.Y);
                    }

                    x = e.X;
                    y = e.Y;
                }
                else if (selectshape == 2)
                {
                    //g.DrawRectangle(p, Math.Min(e.X,x1), Math.Min(e.Y, y1),Math.Abs(e.X-x1), Math.Abs(e.Y - y1));

                    //if (x>0 && y>0)
                    //{
                    //    g.DrawRectangle(p, x1, y1, x3, y3);
                    //}

                    //Invalidate();
                    if (x > 0 && y > 00)
                    {

                        g.FillRectangle(new SolidBrush(paintcolor), x1, y1, e.X - x1, e.Y - y1);
                    }

                    x = e.X;
                    y = e.Y;
                }
                else if (selectshape == 4)
                {


                    if (x > 0 && y > 00)
                    {
                        g.FillEllipse(new SolidBrush(paintcolor), e.X, e.Y, 40, 50);
                    }


                    x = e.X;
                    y = e.Y;
                }


            }

        }


        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog o = new OpenFileDialog();
            //o.Filter = "PNG Files|*.png|JPEG Files|*.jpeg|Bitmap|*.bmp";
            //if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    drawareapanel.BackgroundImage = (Image)Image.FromFile(o.FileName).Clone();
            //    drawareapanel.BackgroundImageLayout = ImageLayout.Zoom;
            //}
            //MessageBox.Show("open");
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // SaveFileDialog sfdlg = new SaveFileDialog();
           // sfdlg.Title = "Save Dialog";
            //sfdlg.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
           // if (sfdlg.ShowDialog(this) == DialogResult.OK)
            //{
                //using (Bitmap bmp = new Bitmap(drawareapanel.Width, drawareapanel.Height))
                //{

                    //drawareapanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                   // drawareapanel.Image = new Bitmap(drawareapanel.Width, drawareapanel.Height);
                   // drawareapanel.Image.Save(sfdlg.FileName);
                    //bmp.Save(sfdlg.FileName);
                   // MessageBox.Show("Saved Successfully.....");

                //}
            //}
        }

        private void showtexturebox_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
           // selectshape = 2;
        }

        public GUI_Based()
        {
            InitializeComponent();
          
            //g = drawareapanel.CreateGraphics();
            //p = new Pen(showcolorbox.BackColor);

            //int x_canvas = drawareapanel.Width / 2;
            //int y_canvas = drawareapanel.Height / 2;
            //lbl_StartPosX.Text = x_canvas.ToString();
            //lbl_StartPosY.Text = y_canvas.ToString();
            //lbl_canvasx.Text = x_canvas.ToString();
            //lbl_canvasy.Text = y_canvas.ToString();


            //bb = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(255, 128, 255, 255));
            //g.FillEllipse(bb, 0, 0, 100, 60);
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
