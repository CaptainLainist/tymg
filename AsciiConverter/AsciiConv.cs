using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiConverter
{
    public class AsciiConv
    {

        //convert to braille
        private static char BrailleConv(int x)
        {
            const int offset = 10240;
            return (char)(offset + x);
        }


        //img width
        private int img_x_;

        public int img_x
        {
            get { return img_x_; }
            set { img_x_ = value; }
        }

        //img height
        private int img_y_;

        public int img_y
        {
            get { return img_y_; }
            set { img_y_ = value; }
        }


        private int darkness_;

        public int darkness
        {
            get { return darkness_; }
            set { darkness_ = value; }
        }

        private string pixels = " .-+*wGHN#&$";

        //translate image to ascii
        public string getTextAscii(string img_loc)
        {
            string finalstring = "";

            Bitmap img_or = new Bitmap(img_loc);
            Bitmap img = new Bitmap(img_or, new Size(img_x_, img_y_));
            for (var y = 0; y < img.Height; y++){
                for (var x = 0; x < img.Width; x++)
                {
                    var color = img.GetPixel(x, y);
                    var brightness = Brightness(color);
                    var idx = brightness / 255 * (pixels.Length - 1);
                    var pxl = pixels[pixels.Length - (int)Math.Round(idx) -1];

                    finalstring += pxl.ToString();
                }
                finalstring += System.Environment.NewLine;
            }

            return finalstring;
        }


        //translate image to braille
        public string getTextBraille(string img_loc) {
            Bitmap img_or = new Bitmap(img_loc);
            Bitmap img = new Bitmap(img_or, new Size(img_x_, img_y_));
            string finalstring = "";
            const int Wi = 2, He = 3;
            int blockX = (int)Math.Ceiling(img.Width / (float)Wi);
            int blockY = (int)Math.Ceiling(img.Height / (float)He);
            for (int y = 0; y < blockY; y++) {
                for (int x = 0; x < blockX; x++) {
                    int bitfield = 0;
                    for (int jx = 0; jx < Wi; jx++) {
                        for (int jy = 0; jy < He; jy++) {
                            int xidx = x * Wi + jx, yidx = y * He + jy;
                            if (xidx > 0 && xidx < img.Width && yidx > 0 && yidx < img.Height)
                            {
                                Color pixel = img.GetPixel(xidx, yidx);
                                if (!Shadow(pixel, darkness_))
                                    bitfield |= (1 << (jx * He + jy));
                            }
                        }
                    }
                    finalstring += (BrailleConv(bitfield));

                }
                finalstring += Environment.NewLine;
            }


            return finalstring;
        }


        //get level of bright for braille
        private static bool Shadow(Color c, int dark) {
            return ((int)c.R + c.G + c.B) / 3 >= dark;
        }
        
        //get level of bright for ascii
        private static double Brightness(Color c)
        {
            return Math.Sqrt(
                c.R * c.R * .241 +
                c.G * c.G * .691 +
                c.B * c.B * .068);
                
        }


    }
}
