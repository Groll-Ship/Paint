using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    public class Brush
    {
        private Color color;
        public Bitmap bitmapImage;
        public int sizeBrash = 0;
        private int widthBorder, heightBorder;
        public Brush(Bitmap b)
        {
            bitmapImage = b;
        }

        public void paintColor(Color clr)
        {
            this.color = clr;
        }
        
        public void CurrentBorder(int widthBorder, int heightBorder)
        {
            this.heightBorder = heightBorder;
            this.widthBorder = widthBorder;
           
        }

        public void BrushPixel(int x, int y)
        {
            
            for (int i = 0; i <= sizeBrash; i++)
            {
                if (x + i < widthBorder && y + i < heightBorder
                    && x - i >= 0 && y - i >= 0)
                    {
                            
                        bitmapImage.SetPixel(x, y + i, color);
                        bitmapImage.SetPixel(x + i, y, color);
                        bitmapImage.SetPixel(x - i, y, color);
                        bitmapImage.SetPixel(x, y - i, color);
                            
                   
                    }
                bitmapImage.SetPixel(x, y, color);
            }


            
            
        }

        public Bitmap DrawLine(int x1, int y1, int x2, int y2)
        {

            double speed;

            double h = y2 - y1, w = x2 - x1;

            if (Math.Abs(h) >= Math.Abs(w))
            {
                speed = h != 0 ? w / h : 1;
                if (h >= 0)
                {
                    for (int i = 0; i <= h; i++)
                    {
                        int j = Convert.ToInt32(i * speed);
                        BrushPixel(x1 + j, y1 + i);

                    }
                }
                else
                {
                    for (int i = Convert.ToInt32(h); i <= 0; i++)
                    {
                        int j = Convert.ToInt32(i * speed);
                        BrushPixel(x1 + j, y1 + i);
                    }
                }

            }
            else
            {
                speed = w != 0 ? h / w : 1;
                if (w >= 0)
                {
                    for (int i = 0; i <= w; i++)
                    {
                        int j = Convert.ToInt32(i * speed);
                        BrushPixel(x1 + i, y1 + j);
                    }
                }
                else
                {
                    for (int i = Convert.ToInt32(w); i <= 0; i++)
                    {
                        int j = Convert.ToInt32(i * speed);
                        BrushPixel(x1 + i, y1 + j);
                    }
                }
            }

            return bitmapImage;
        }
    }
}
