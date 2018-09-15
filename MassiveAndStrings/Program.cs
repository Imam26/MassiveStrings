using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
 * Программа должна сосчитать количество введенных пользователем пробелов.*/

namespace Programm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите символы: ");
            ConsoleKeyInfo key = Console.ReadKey();
            int count = 0;
            while(key.KeyChar!='.')
            {
                if (key.KeyChar == ' ') count++;
                key = Console.ReadKey();
            }
            Console.WriteLine("\nКоличество пробелов: {0}", count);
            Console.ReadKey();
        }
    }
}
