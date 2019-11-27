using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bitMapImage;
        Color colorBrush = Color.Black;
        bool pen = false;
        bool FMouseLeft = false;
        int x, y;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            bitMapImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitMapImage;
            
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            FMouseLeft = true;
            this.x = e.X;
            this.y = e.Y;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (FMouseLeft && e.Location.X < pictureBox1.Width && e.Location.Y < pictureBox1.Height
                && e.Location.X >= 0 && e.Location.Y >= 0)
            {
                if (pen)
                {
                    Brush b = new Brush(bitMapImage);
                    b.CurrentBorder(pictureBox1.Width, pictureBox1.Height);
                    b.sizeBrash = sizeBrash.Value;
                    b.paintColor(colorBrush);
                    b.DrawLine(x, y, e.X, e.Y);
                    x = e.X;
                    y = e.Y;
                    pictureBox1.Image = b.bitmapImage;

                }
                

            }
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            FMouseLeft = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            bitMapImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitMapImage;
        }

        private void sizeBrash_Scroll(object sender, EventArgs e)
        {
        
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color.BackColor = colorDialog1.Color;
                colorBrush = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            FMouseLeft = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Pen_Click(object sender, EventArgs e)
        {
            if (!pen)
            {
                Pen.FlatAppearance.BorderSize = 1;
                
                pen = true;

            }
            else
            {
                Pen.FlatAppearance.BorderSize = 0;
                
                pen = false;
            }
        }

        private void SizeCursor(Cursor cursor)
        {
            
        }
    }
}
