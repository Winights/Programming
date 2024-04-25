﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public class RectangleFactory
    {
        public static Rectangle Randomize()
        {
            Random ran = new Random();

            double length = ran.Next(1, 100);
            double width = ran.Next(1, 100);
            double centerX = ran.Next(1, 355);
            double centerY = ran.Next(1, 473);
            Point2D center = new Point2D(centerX, centerY);

            return new Rectangle(length, width, "", center);
        }
    }
}
