﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValyaLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд - целое неотрицательное число");
          

            string nStr = Console.ReadLine();
            int n; //количество секунд
            if (Int32.TryParse(nStr, out n) && n > 0)
            {
                Console.WriteLine($"Каждое тело имеет свою скорость, поэтому введите, какой путь P проходит Ваше тело за 1 секунду, а мы расчитаем его пройденный путь за {n} секунд");
                string pStr = Console.ReadLine();
                double p;

                if (Double.TryParse(pStr, out p) && p > 0)
                {
                    double summa = 0;
                    for (int i = 1; i < n + 1; i++) //цикл контроля секунд
                    {
                        for (int j = 0; j < n + 1; j++) //цикл контроля слагаемого
                        {
                            if (j == i - 1)
                            {
                                summa += p * Math.Sqrt(i) + j;
                                Console.WriteLine($"Секунда: {i}, слагаемое: {j}, формула: P*sqrt({i})+{j}={p * Math.Sqrt(i) + j}, сумма в данный момент {summa}");
                            }

                        }

                    }
                }
                else
                {
                    Console.WriteLine("Некорректные входные данные");

                }
                
            }
            else
            {
                Console.WriteLine("Некорректные входные данные");
            }
            
            
            Console.ReadLine();
        }
    }
}
