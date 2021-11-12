using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class SixthFractal : Form
    {
        /// <summary>
        /// Коэффициент.
        /// </summary>
        public double Coef { get; set; }

        /// <summary>
        /// Первый угол.
        /// </summary>
        public double Angle1 { get; set; }

        /// <summary>
        /// Второй угол.
        /// </summary>
        public double Angle2 { get; set; }

        /// <summary>
        /// Конструктор для шестого фрактала.
        /// </summary>
        /// <param name="coef">Коэффициент.</param>
        /// <param name="angleOne">Первый угол.</param>
        /// <param name="angleTwo">Второй угол.</param>
        public SixthFractal(double coef, double angleOne, double angleTwo)
        {
            InitializeComponent();
            ResizeRedraw = true;
            Coef = coef;
            Angle1 = angleOne;
            Angle2 = angleTwo;
        }

        /// <summary>
        /// Метод перерисовки фрактального дерева.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            DrawBeautifulTreeFractal(this.Width / 2, 20, this.Height / 4, 0, e, this.Height, Coef, Angle1, Angle2);
        }

        /// <summary>
        /// Метод чтобы нарисовать красивое фрактальное дерево без итараций.
        /// </summary>
        /// <param name="step">Шаги.</param>
        /// <param name="x">Точка Х.</param>
        /// <param name="y">Точка У.</param>
        /// <param name="length">Длина отрезка.</param>
        /// <param name="angle">Угол.</param>
        /// <param name="e"></param>
        /// <param name="height">Высота.</param>
        /// <param name="coef">Коэффициэнт.</param>
        /// <param name="angle1">Первый угол.</param>
        /// <param name="angle2">Второй угол.</param>
        public void DrawBeautifulTreeFractal(int x, int y, int length, double angle, PaintEventArgs e,
            int height, double coef, double angle1, double angle2)
        {
            Graphics g = e.Graphics;
            double x1 = x + length * Math.Sin(angle * Math.PI * 2 / 360.0);
            double y1 = y + length * Math.Cos(angle * Math.PI * 2 / 360.0);
            g.DrawLine(new Pen(Color.White), x, height - y, (int)x1, height - (int)y1);

            if (length > 2)
            {
                DrawBeautifulTreeFractal((int)x1, (int)y1, (int)(length / coef), angle + angle1, e, height, coef, angle1, angle2);
                DrawBeautifulTreeFractal((int)x1, (int)y1, (int)(length / coef), angle - angle2, e, height, coef, angle1, angle2);
            }
        }
    }
}
