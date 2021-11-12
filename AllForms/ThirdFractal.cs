using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class ThirdFractal : Form
    {
        /// <summary>
        /// Количество шагов.
        /// </summary>
        public int Step { get; set; }

        /// <summary>
        /// Конструктор третьего фрактала.
        /// </summary>
        /// <param name="step">Количество шагов.</param>
        public ThirdFractal(int step)
        {
            Step = step;
            ResizeRedraw = true;
            InitializeComponent();
        }

        /// <summary>
        /// Метод чтобы перерисовывать ковер Серпинского.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics graphics = e.Graphics;
            int[] nums = { this.Height, this.Width };
            RectangleF rectangle = new RectangleF((nums.Max() == this.Width) ? (nums.Max() / 4) : 1, 
                (nums.Max() == this.Width) ? 1 : (nums.Max() / 4), nums.Min() - 45, nums.Min() - 45);
            Fractal.DrawRectangle(graphics, Step, rectangle, Brushes.White);
        }
    }
}
