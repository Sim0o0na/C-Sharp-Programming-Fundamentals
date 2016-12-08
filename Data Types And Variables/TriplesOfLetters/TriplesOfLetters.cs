using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        char letter = (char)('a' + num);
                        Console.WriteLine("{0}{1}{2}", (char)('a' + i), (char)('a' + j), (char)('a' + k));
                    }
                }
            }
        }
    }
}
