using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7 {
    class Ex4 {
        public static void run() {
            Point p = new Point(1, 1);
            Square s = new Square(p, 2);
            s.DisplayCorners();
        }
    }

    class Point {
        public int x, y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public void Display() {
            Console.WriteLine(x + " " + y);
        }
    }

    class Square {
        private Point p1, p2, p3, p4;

        public Square(Point p, int l) {
            p1 = p;
            p2 = new Point(p.x + l, p.y);
            p3 = new Point(p.x, p.y + l);
            p4 = new Point(p.x + l, p.y + l);
        }

        public void DisplayCorners() {
            p1.Display();
            p2.Display();
            p3.Display();
            p4.Display();
        }
    }
}
