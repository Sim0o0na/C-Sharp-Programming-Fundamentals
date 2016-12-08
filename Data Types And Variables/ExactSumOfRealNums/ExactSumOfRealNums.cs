using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNums
{
    class ExactSumOfRealNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for(int i=0; i<n; i++){
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
