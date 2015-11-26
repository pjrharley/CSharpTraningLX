using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12 {
    class Ex1 {
        static public void run() {
            Invoice a = new Invoice("hello", 1.2);
            Invoice b = new Invoice("hello", 2.0);
            Invoice c = new Invoice();
            Console.WriteLine(a + b);
            Console.WriteLine(a + c);
        }
    }

    class Invoice {
        string vendor;
        double amount;

        public Invoice() { }

        public Invoice(string vendor, double amount) {
            this.vendor = vendor;
            this.amount = amount;
        }

        public static Invoice operator +(Invoice a, Invoice b) {
            if (a.vendor == b.vendor) {
                return new Invoice(a.vendor, a.amount + b.amount);
            }
            return new Invoice();
        }

        public static bool operator ==(Invoice lhs, Invoice rhs) {
            if (lhs.amount == rhs.amount && lhs.vendor == rhs.vendor) {
                return true;
            }
            return false;
        }

        public static bool operator !=(Invoice lhs, Invoice rhs) {
            return !(lhs == rhs);
        }

        public static bool operator >(Invoice lhs, Invoice rhs) {
            if (lhs.vendor == rhs.vendor && lhs.amount > rhs.amount) {
                return true;
            }
            return false;
        }

        public static bool operator <(Invoice lhs, Invoice rhs) {
            if (lhs.vendor == rhs.vendor && lhs.amount < rhs.amount) {
                return true;
            }
            return false;
        }

        public override string ToString() {
            return "Vendor: " + vendor + "\nAmount: " + amount;
        }
    }
}
