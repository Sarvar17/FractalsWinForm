using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class FifthFractal : Form
    {
        /// <summary>
        /// Количество шагов.
        /// </summary>
        public int Step { get; set; }

        /// <summary>
        /// Расстояние между отрезками.
        /// </summary>
        public float Distance { get; set; }

        /// <summary>
        /// Конструктор пьятого фрактала.
        /// </summary>
        /// <param name="step">Количество шагов.</param>
        /// <param name="distance">Расстояние между отрезками.</param>
        public FifthFractal(int step, float distance)
        {
            ResizeRedraw = true;
            Step = step;
            Distance = distance;
            InitializeComponent();
        }

        /// <summary>
        /// Метод перерисовки фрактала множества Кантора.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            Fractal.DrawCantorsSet(Step, Distance, new RectangleF(10f, 10f, this.Width - 32f, 25f), g, Brushes.White, true);
        }
    }
}
