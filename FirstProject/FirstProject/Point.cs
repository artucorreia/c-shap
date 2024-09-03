using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject {
    struct Point {
    
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y) {
            X = x; 
            Y = y;
        }

        public override readonly string ToString() => $"x: {X}, y: {Y}";
    }
}
