using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int  num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i<= num; i++) {
                string str = Convert.ToString(i);
                for(int j=0; j<str.Length; j++){
                    int character = str[j] - '0';
                    sum += character;
                }
                if (sum==7 || sum==5 || sum == 11){
                    Console.WriteLine("{0} -> True", i);
                }else {
                    Console.WriteLine("{0} -> False", i);
                }
                sum = 0;
            }
            
        }
    }
}
