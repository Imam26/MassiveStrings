using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является 
 * ли данный билет счастливым (если на билете напечатано шестизначное число, 
 * и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).*/

namespace Programm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета: ");
            int num, sum = 0;
            for(int i = 0; i < 6; i++)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(int.TryParse(key.KeyChar.ToString(),out num))
                {
                    sum += i<3?num:(-1)*num;
                }
                else
                {
                    Console.Write("\b");
                    i--;
                }
            }
            if (sum == 0) Console.WriteLine("\nБилет счастливый!!!");
            else Console.WriteLine("\nБилет не счастливый");
        }
    }
}
