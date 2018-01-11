using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16 {
    class Ex1 {
        static public void Run() {
            bool tryAgain = true;
            int[] ints = new int[] { 1, 2, 3 };
            while(tryAgain) {
                Console.WriteLine("CHoose an element, enter 1 - 3");
                try {
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("the number you are asking is: {0}", ints[input - 1]);
                } catch (IndexOutOfRangeException) {
                    Console.WriteLine("pls enter a number of 1, 2 or 3");
                } catch (FormatException) {
                    Console.WriteLine("pls enter only numbers");
                } catch {
                    Console.WriteLine("invalid inputs");
                }
                Console.WriteLine("try again? y/n");
                string reply = Console.ReadLine();
                tryAgain = (reply == "y" || reply == "Y");
            }
        }
    }
}
