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
        private Point BotLeftCorner, BotRightCorner, TopLeftCorner, TopRightCorner;

        public Square(Point p, int l) {
            BotLeftCorner = p;
            BotRightCorner = new Point(p.x + l, p.y);
            TopLeftCorner = new Point(p.x, p.y + l);
            TopRightCorner = new Point(p.x + l, p.y + l);
        }

        public void DisplayCorners() {
            BotLeftCorner.Display();
            BotRightCorner.Display();
            TopLeftCorner.Display();
            TopRightCorner.Display();
        }
    }
}
