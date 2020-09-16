﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lớp_hình_chữ_nhật
{
    public class Rectangle
    {
        double width, height;

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //code below here

        public double GetArea()
        {
            return this.width * this.height;
        }

        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }

        public string Display()
        {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";
        }
    }


}
