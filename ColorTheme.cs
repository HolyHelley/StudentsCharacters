using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCharacter
{
    public static class ColorTheme
    {
        public static Color Color1;
        public static Color Color2;
        public static ThemeType ThemeType;
        public static void ChangeBack(PaintEventArgs e, int width,int height)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
               new Point(0, 0),
               new Point(0, height),
               Color1,
               Color2);
            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 0, 0, width, height);
        }
        public static void SetTheme(Form form)
        {
            if (ThemeType == ThemeType.light)
            {
                Color1 = Color.FromArgb(255, 0, 64, 107);
                Color2 = Color.FromArgb(255, 5, 155, 255);
                form.Invalidate();

            }
            if (ThemeType == ThemeType.dark)
            {
                Color1 = Color.FromArgb(255, 0, 33, 55);
                Color2 = Color.FromArgb(255, 14, 104, 143);
                form.Invalidate();
            }
        }

    }
    public enum ThemeType
    {
        light, dark
    }
}
