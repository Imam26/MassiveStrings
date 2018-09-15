using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра
 на величину 32. Используя эту информацию, написать программу, которая считывает 
 с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.*/

namespace Programm3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для конвертации в вверхний регистр:");
            string strDown = Console.ReadLine();
            string strUp = null;
            for(int i = 0; i<strDown.Length; i++)
            {
                if (strDown[i] >= 'a' && strDown[i] <= 'я')
                    strUp += Convert.ToChar(strDown[i] - 32).ToString();
                else strUp += strDown[i];
            }
            Console.WriteLine(strUp);
            Console.WriteLine("Введите строку для конвертации в нижний регистр:");
            strUp = strDown = null;
            strUp = Console.ReadLine();
            for(int i = 0; i<strUp.Length; i++)
            {
                if ((strUp[i] >= 'А' && strUp[i] <= 'Я')|| (strUp[i] >= 'A' && strUp[i] <= 'Z'))
                    strDown += Convert.ToChar(strUp[i] + 32).ToString();
                else strDown += strUp[i];
            }
            Console.WriteLine(strDown);
        }
    }
}
