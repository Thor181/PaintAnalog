using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogPaint
{
    internal class ArrayPoints
    {
        private int currentIndex = 0;
        private Point[] points;

        public ArrayPoints(int size)
        {
            if (size <= 0)
            {
                size = 2;
            }
            points = new Point[size];
        }

        public void SetPoint(int x, int y)
        {
            if (currentIndex >= points.Length)
            {
                currentIndex = 0;
            }
            points[currentIndex] = new Point(x, y);
            currentIndex++;
        }

        public void ResetCurrentIndex()
        {
            currentIndex = 0;
        }

        public int GetCountPoints()
        {
            return currentIndex;
        }

        public Point[] GetPoints()
        {
            return points;
        }
    }
}
