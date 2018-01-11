using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10 {
    class Ex2 {
        static public void run() {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(nums);
            foreach (int n in nums) Console.WriteLine(n);
        }
    }
}
