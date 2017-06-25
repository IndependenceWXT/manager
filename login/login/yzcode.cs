using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace login
{
    class yzcode
    {
        //验证码字符串
        public string checkstring = string.Empty;
        //用于获取验证码字符串，用于比较
        public string Check
        {
            get
            {
                return checkstring;
            }

            set
            {
                checkstring = value;
            }
        }
        public Bitmap identifying(int w,int h)
        {
            //新建Bitmap
            Bitmap img = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(img);
            Random rnd = new Random();
            //1.设置随机的背景颜色,产生淡色系的背景
            int bgR = rnd.Next(210, 256);
            int bgG = rnd.Next(210, 256);
            int bgB = rnd.Next(210, 256);
            g.Clear(Color.FromArgb(bgR, bgG, bgB));
            //2.写入100个颜色，位置不同的干扰点
            for (int i = 0; i < 100; i++)
            {
                //到200保证产生的颜色和背景不冲突
                int dR = rnd.Next(200);
                int dG = rnd.Next(200);
                int dB = rnd.Next(200);
                int x = rnd.Next(w);
                int y = rnd.Next(h);
                Color dc = Color.FromArgb(dR, dG, dB);
                img.SetPixel(x, y, dc);
            }
            //3.写入3条干扰线
            for (int i = 0; i < 3; i++)
            {
                int R = rnd.Next(200);
                int G = rnd.Next(200);
                int B = rnd.Next(200);
                int x1 = rnd.Next(w);
                int y1 = rnd.Next(h);
                int x2 = rnd.Next(w);
                int y2 = rnd.Next(h);
                Color color = Color.FromArgb(R, G, B);
                g.DrawLine(new Pen(color), x1, y1, x2, y2);
            }
            //写入字符串,去除1,i,o,0等易混淆字符
            char[] allchar = { '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'W', 'X', 'Y' };
            //清空验证码字符串
            checkstring = string.Empty;
            //4.写入四位验证码字符串
            for (int i = 0; i < 4; i++)
            {
                checkstring += allchar[rnd.Next(allchar.Length)];
            }
            //定义随机大小字体
            int fontsize = rnd.Next(15, 23);
            Font CFont = new Font("Times New Roman", fontsize);
            //向图片写入验证字符串
            for (int i = 0; i < checkstring.Length; i++)
            {
                int R = rnd.Next(200);
                int G = rnd.Next(200);
                int B = rnd.Next(200);
                Color c = Color.FromArgb(R, G, B);
                g.DrawString(checkstring.ToString(), CFont, new SolidBrush(c), 2, 2);
            }

           
            //输出图片
            return img;
            //this.pcaptcha.Image = image;
        }
    }

}
