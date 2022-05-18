using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using System.Threading;
namespace HexColor
{
    public partial class Form1 : Form
    {
        int r, g, b;
        Bitmap color_chooser_bitmap;
        bool mouse_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        //[DllImport("kernel32.dll")]
        //public static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            color_chooser_bitmap = new Bitmap(128, 128);
            update();
            Thread chooser_thread = new Thread(new ThreadStart(color_select_thread));
            chooser_thread.Start();
        }
        private void update() 
        {
            Color color = Color.FromArgb(r, g, b);
            R_Color_Box.Text = r.ToString();
            G_Color_Box.Text = g.ToString();
            B_Color_Box.Text = b.ToString();

            R_Color.Value = r;
            G_Color.Value = g;
            B_Color.Value = b;

            RGB_Value.Text = $"{r},{g},{b}";
            Hex_Value.Text = $"#{r.ToString("X2")}{g.ToString("X2")}{b.ToString("X2")}";

            BackColor = color;

            float r_p = r / 255.0f;
            float g_p = g / 255.0f;
            float b_p = b / 255.0f;

            double k = 1.0f - Math.Max(Math.Max(r_p, g_p), b_p);
            double c = k == 1 ? 0 : ( (1.0 - r_p - k) / (1.0 - k)  );
            double m = k == 1 ? 0 : ( (1.0 - g_p - k) / (1.0 - k) );
            double y = k == 1 ? 0 : ( (1.0 - b_p - k) / (1.0 - k) );

            int h = (int)color.GetHue();
            int s = (int)(color.GetSaturation()*100);
            int v = (int)(color.GetBrightness()*100);

            HSV_Value.Text = $"{h}°,{s}%,{v}%";


            c = Math.Round(c * 100.0f);
            m = Math.Round(m * 100.0f);
            y= Math.Round(y * 100.0f);
            k = Math.Round(k * 100.0f);

            CMYK_Value.Text = $"{c},{m},{y},{k}";

            UpdateColorBox(color);
        }
        private void update(Color color)
        {
            r = color.R;
            g = color.G;
            b = color.B;
            update();
        }
        private void color_select_thread()
        {
            while (!Disposing)
            {
                if (mouse_pressed)
                {
                    float relative_x = Cursor.Position.X - Left - color_chooser.Location.X;
                    float relative_y = Cursor.Position.Y - Top - color_chooser.Location.Y;

                    int x = (int) ((relative_x / (float)color_chooser.Width) * color_chooser_bitmap.Width);
                    int y = (int) ((relative_y / (float)color_chooser.Height) * color_chooser_bitmap.Height);

                    x = Math.Min(color_chooser_bitmap.Width - 1, Math.Max(0, x));
                    y = Math.Min(color_chooser_bitmap.Height - 1, Math.Max(0, y));

                    Color new_color = color_chooser_bitmap.GetPixel(x, y);

                    //HSV_Value.Invoke((Action)delegate { HSV_Value.Text = $"{x}:{y} {bitmap.Width}:{bitmap.Height}"; });
                    Invoke((Action)delegate { update(new_color); });
                }
            }
        }
        private Color lerpColorRGB(Color c1,Color c2,float t)
        {
            return Color.FromArgb(
                (int) (c1.R * (1 - t) + c2.R * t),
                (int) (c1.G * (1 - t) + c2.G * t),
                (int) (c1.B * (1 - t) + c2.B * t)
            );
        }
        private Color HueToRGB(float hue,float saturation,float value)
        {
//https://www.rapidtables.com/convert/color/hsv-to-rgb.html
            float c = value * saturation;
            float x = c * (1.0f - Math.Abs((hue / 60.0f) % 2.0f - 1.0f));

            float[] rgb_prim = new float[] { 0, 0, 0 };
            //rgb_prim = { 23,31,3};
            if (hue < 60)
                rgb_prim = new float[] { c, x, 0 };
            else if (hue < 120)
                rgb_prim = new float[] { x, c, 0 };
            else if (hue < 180)
                rgb_prim = new float[] { 0, c, x };
            else if (hue < 240)
                rgb_prim = new float[] { 0, x, c };
            else if (hue < 300)
                rgb_prim = new float[] { x, 0, c };
            else if (hue < 360)
                rgb_prim = new float[] { c, 0, x };

            float m = value - c;

            int r = (int)((rgb_prim[0] + m) * 255.0f);
            int g = (int)((rgb_prim[1] + m) * 255.0f);
            int b = (int)((rgb_prim[2] + m) * 255.0f);
            return Color.FromArgb(r, g, b);
        }
        private void UpdateColorBox(Color color)
        {
            float hue = color.GetHue();
            color = HueToRGB(hue, 1, 1);

            for(int x = 0;x < 128; x++)
            {
                for(int y = 0; y < 128; y++)
                {
                    float xt = x / 128.0f;
                    float yt = y / 128.0f;

                    Color saturated = lerpColorRGB(color, Color.White, 1 - xt);
                    Color blacken = lerpColorRGB(saturated, Color.Black, yt);

                    color_chooser_bitmap.SetPixel(x, y, blacken);
                }
            }
            color_chooser.Image = color_chooser_bitmap;
            color_chooser.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Update();
            R_Color.Update();
            B_Color.Update();
            G_Color.Update();
        }
        private int parse_color_box(string value)
        {
            int result = 0;
            if(int.TryParse(value,out result))
            {
                result = Math.Min(Math.Max(0, result), 255);
            }
            return result;
        }
        private void R_Color_Box_TextChanged(object sender, EventArgs e)
        {
            int parsed = parse_color_box(R_Color_Box.Text);
            r = parsed;
            update();
        }

        private void R_color_Scroll(object sender, EventArgs e)
        {
            r = R_Color.Value;
            update();
        }

        private void color_chooser_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_pressed = true;
        }

        private void color_chooser_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_pressed = false;
        }

        private void color_chooser_MouseLeave(object sender, EventArgs e)
        {
            mouse_pressed = false;
        }

        private void HSV_Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void HSV_Color_Scroll(object sender, EventArgs e)
        {
            Color color = HueToRGB(HSV_Color.Value, 1, 1);
            update(color);
        }

        private void G_color_Scroll(object sender, EventArgs e)
        {
            g = G_Color.Value;
            update();
        }

        private void B_Color_Scroll(object sender, EventArgs e)
        {
            b = B_Color.Value;
            update();
        }

        private void G_Color_Box_TextChanged(object sender, EventArgs e)
        {
            int parsed = parse_color_box(G_Color_Box.Text);
            g = parsed;
            update();
        }

        private void B_Color_Box_TextChanged(object sender, EventArgs e)
        {
            int parsed = parse_color_box(B_Color_Box.Text);
            b = parsed;
            update();
        }
    }
}
