using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; 
каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, 
равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
*/

namespace Programm4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 3, B = 7;
            for(int i = A; i<=B; i++)
            {
                for(int j = 0; j<i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
