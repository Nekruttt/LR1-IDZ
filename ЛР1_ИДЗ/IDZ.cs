using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1_ИДЗ
{
    internal class IDZ
    {
        public static void DoTask()
        {
            Console.Write("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());
            float [] numb = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите "+(i+1)+" число ");
                numb[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Сумма минимального элемента и след.мин.элемента равна: ");
            float min=numb.Min();
            float min2 = float.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (min < numb[i] && numb[i]<min2)
                {
                    min2= numb[i];
                }
            }
            Console.WriteLine(min + min2);
        }
    }
}
