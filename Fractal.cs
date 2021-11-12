using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public class Fractal
    {
        /// <summary>
        /// Количество шагов.
        /// </summary>
        public int Steps { get; set; }

        /// <summary>
        /// Коэффициэнт.
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
        /// Метод чтобы нарисовать кривую Коха.
        /// </summary>
        /// <param name="step">Шаги.</param>
        /// <param name="x">Точка Х.</param>
        /// <param name="y">Точка У.</param>
        /// <param name="angle">Угол.</param>
        /// <param name="len">Длина отрезка.</param>
        /// <param name="e"></param>
        public static void DrawFractalKoch(int step, int x, int y, int angle, double len, Graphics g, Color color)
        {
            double x1, y1;
            if (step == 0)
            {
                x1 = x + len * Math.Cos(angle * Math.PI * 2 / 360.0);
                y1 = y + len * Math.Sin(angle * Math.PI * 2 / 360.0);
                g.DrawLine(new Pen(color), x, y, (int)x1, (int)y1);
            }
            else
            {
                DrawFractalKoch(step - 1, x, y, angle, len / 3, g, color);
                double x2 = x + len / 3 * Math.Cos(angle * Math.PI * 2 / 360.0);
                double y2 = y + len / 3 * Math.Sin(angle * Math.PI * 2 / 360.0);
                DrawFractalKoch(step - 1, (int)x2, (int)y2, angle - 60, len / 3, g, color);
                double x3 = x2 + len / 3 * Math.Cos((angle - 60) * Math.PI * 2 / 360.0);
                double y3 = y2 + len / 3 * Math.Sin((angle - 60) * Math.PI * 2 / 360.0);
                DrawFractalKoch(step - 1, (int)x3, (int)y3, angle + 60, len / 3, g, color);
                double x4 = x3 + len / 3 * Math.Cos((angle + 60) * Math.PI * 2 / 360.0);
                double y4 = y3 + len / 3 * Math.Sin((angle + 60) * Math.PI * 2 / 360.0);
                DrawFractalKoch(step - 1, (int)x4, (int)y4, angle, len / 3, g, color);
            }
        }

        /// <summary>
        /// Метод чтобы нарисовать фрактальное дерево.
        /// </summary>
        /// <param name="step">Шаги.</param>
        /// <param name="x">Точка Х.</param>
        /// <param name="y">Точка У.</param>
        /// <param name="length">Длина отрезка.</param>
        /// <param name="angle">Угол.</param>
        /// <param name="e"></param>
        /// <param name="height">Высота.</param>
        /// <param name="coef">Коэффициэнт.</param>
        /// <param name="Angle1">Первый угол.</param>
        /// <param name="Angle2">Второй угол.</param>
        public static void DrawTreeFractal(int step, int x, int y, int length, double angle, Graphics g, 
            int height, double coef, double Angle1, double Angle2, Color color)
        {
            double x1 = x + length * Math.Sin(angle * Math.PI * 2 / 360.0);
            double y1 = y + length * Math.Cos(angle * Math.PI * 2 / 360.0);
            if (step == 0)
            {
                g.DrawLine(new Pen(color), x, height - y, (int)x1, height - (int)y1);
            }

            if (length > 2 && step > 0)
            {
                DrawTreeFractal(step - 1, x, y, (int)(length), angle, g, height, coef, Angle1, Angle2, color);
                DrawTreeFractal(step - 1, (int)x1, (int)y1, (int)(length / coef), angle + Angle1, g, height, coef, Angle1, Angle2, color);
                DrawTreeFractal(step - 1, (int)x1, (int)y1, (int)(length / coef), angle - Angle2, g, height, coef, Angle1, Angle2, color);
            }
        }

        /// <summary>
        /// Метод чтобы нарисовать коверь Серпинского.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="step">Шаги.</param>
        /// <param name="rectangle">Прямоугольник.</param>
        public static void DrawRectangle(Graphics e, int step, RectangleF rectangle, Brush brush)
        {
            if (step == 0)
            {
                e.FillRectangle(brush, rectangle);
            }
            else
            {
                float wid = rectangle.Width / 3f;
                float x0 = rectangle.Left;
                float x1 = x0 + wid;
                float x2 = x0 + wid * 2f;

                float hgt = rectangle.Height / 3f;
                float y0 = rectangle.Top;
                float y1 = y0 + hgt;
                float y2 = y0 + hgt * 2f;

                DrawRectangle(e, step - 1, new RectangleF(x0, y0, wid, hgt), brush);
                DrawRectangle(e, step - 1, new RectangleF(x1, y0, wid, hgt), brush);
                DrawRectangle(e, step - 1, new RectangleF(x2, y0, wid, hgt), brush);
                DrawRectangle(e, step - 1, new RectangleF(x0, y1, wid, hgt), brush);
                DrawRectangle(e, step - 1, new RectangleF(x2, y1, wid, hgt), brush);
                DrawRectangle(e, step - 1, new RectangleF(x0, y2, wid, hgt), brush);
                DrawRectangle(e, step - 1, new RectangleF(x1, y2, wid, hgt), brush);
                DrawRectangle(e, step - 1, new RectangleF(x2, y2, wid, hgt), brush);
            }
        }

        /// <summary>
        /// Метод чтобы нарисовать треугольник Серпинского.
        /// </summary>
        /// <param name="step">Шаги.</param>
        /// <param name="topPoint">Верхняя точка.</param>
        /// <param name="leftPoint">Точка слева.</param>
        /// <param name="rightPoint">Точка справа.</param>
        /// <param name="e"></param>
        public static void DrawSierpinskiTriangle(int step, PointF topPoint, PointF leftPoint, PointF rightPoint, Graphics g, Brush brush)
        {
            if (step == 0)
            {
                PointF[] points = { topPoint, rightPoint, leftPoint };
                g.FillPolygon(brush, points);
            }
            else
            {
                PointF leftMid = new PointF(
                    (topPoint.X + leftPoint.X) / 2,
                    (topPoint.Y + leftPoint.Y) / 2);
                PointF rightMid = new PointF(
                    (topPoint.X + rightPoint.X) / 2,
                    (topPoint.Y + rightPoint.Y) / 2);
                PointF bottomMid = new PointF(
                    (leftPoint.X + rightPoint.X) / 2,
                    (leftPoint.Y + rightPoint.Y) / 2);

                DrawSierpinskiTriangle(step - 1, topPoint, leftMid, rightMid, g, brush);
                DrawSierpinskiTriangle(step - 1, leftMid, leftPoint, bottomMid, g, brush);
                DrawSierpinskiTriangle(step - 1, rightMid, bottomMid, rightPoint, g, brush);
            }
        }

        /// <summary>
        /// Метод чтобы нарисовать множество Кантора.
        /// </summary>
        /// <param name="step">Шаги.</param>
        /// <param name="distance">Расстояние между отрезками.</param>
        /// <param name="rect">Прямоугольник.</param>
        /// <param name="e"></param>
        public static void DrawCantorsSet(int step, double distance, RectangleF rect, Graphics g, Brush brush, bool yesOrNot)
        {
            if (step == 0)
            {
                g.FillRectangle(brush, rect.X, rect.Y, rect.Width, 20f);
            }
            else
            {
                float x1 = rect.X;
                float y1 = rect.Y + (float)distance + 20f;
                float x2 = rect.X + (2 * rect.Width / 3);
                float y2 = rect.Y + (float)distance + 20f;
                DrawCantorsSet(step - 1, distance, new RectangleF(rect.X, rect.Y, rect.Width, 10), g, brush, yesOrNot);
                if (rect.Width < 1f && yesOrNot) rect.Width = 1f;
                DrawCantorsSet(step - 1, distance, new RectangleF(x1, y1, rect.Width / 3, 10), g, brush, yesOrNot);
                DrawCantorsSet(step - 1, distance, new RectangleF(x2, y2, rect.Width / 3, 10), g, brush, yesOrNot);
            }
        }
    }
}
