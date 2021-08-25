﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Projeto.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
        
    }
}
