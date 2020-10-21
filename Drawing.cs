﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_Editor
{
    class Drawing
    {
        private readonly Form1 _form;

        public Drawing(Form1 form)
        {
            _form = form;
        }

        public void drawPoint(int x, int y, Color color)
        {
            Graphics g;
            g = Graphics.FromImage(_form.Image);
            SolidBrush b = new SolidBrush(color);
            g.FillRectangle(b, x, y, 1, 1);
            _form.pictureBox.Image = _form.Image;
            g.Dispose();
        }

        public void drawLine(int x1, int y1, int x2, int y2, Color color)
        {
            Graphics g;
            g = Graphics.FromImage(_form.Image);
            Pen p = new Pen(color);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            g.DrawLine(p, p1, p2);
            _form.pictureBox.Image = _form.Image;
            g.Dispose();
        }
    }
}
