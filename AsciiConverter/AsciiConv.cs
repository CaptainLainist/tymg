using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiConverter
{
    public class AsciiConv
    {

        private static char BrailleConv(int x)
        {
            const int offset = 10240;
            return (char)(offset + x);
        }


        private int darkness_;

        public int darkness
        {
            get { return darkness_; }
            set { darkness_ = value; }
        }

        public string getText(string img_loc) {
            Bitmap img_or = new Bitmap(img_loc);
            Bitmap img = new Bitmap(img_or, new Size(50, 50));
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


        private static bool Shadow(Color c, int dark) {
            return ((int)c.R + c.G + c.B) / 3 >= dark;
        }
        

    }
}
