using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
 * Например, если было введено число 345, то программа должна вывести число 543.*/

namespace Programm5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 987654321;
            int res = 0;
            while (num != 0)
            {
                res *= 10;
                res += num%10;
                num = num / 10;
            }
            Console.WriteLine(res);
        }
    }
}
