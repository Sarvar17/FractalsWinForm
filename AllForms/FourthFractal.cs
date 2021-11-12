using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class FourthFractal : Form
    {
        /// <summary>
        /// Количество шагов.
        /// </summary>
        public int Step { get; set; }

        /// <summary>
        /// Конструктор четвертого фрактала.
        /// </summary>
        /// <param name="step">Количество шагов.</param>
        public FourthFractal(int step)
        {
            Step = step;
            ResizeRedraw = true;
            InitializeComponent();
        }

        /// <summary>
        /// Метод перерисовки треугольника Серпинского.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            PointF left_point = new PointF(5f, this.Height - 50);
            PointF right_point = new PointF(this.Width - 20, this.Height - 50);
            PointF top_point = new PointF((this.Width - 10) / 2, 5);
            base.OnPaintBackground(e);

            Graphics g = e.Graphics;
            Fractal.DrawSierpinskiTriangle(Step, top_point, left_point, right_point, g, Brushes.White);
        }
    }
}