using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01dz_KarakozovVitaly
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka, strokaX, strokaY;
            Console.WriteLine("Введите координаты, в формате 23.8976,12.3218");
            Console.WriteLine("X и Y разделенные запятой");
            stroka = Console.ReadLine();

            // Проверим введеную строку, чтобы там были только цифры, точка и запятая
            bool check;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] >= '0' && stroka[i] <= '9' || stroka[i] == ',' || stroka[i] == '.')
                {
                    check = true;
                }
                else
                {
                    check = false;
                    Console.WriteLine("Некорректный фомат. Введите координаты, в формате 23.8976,12.3218");
                }

            }

            // Разбираем строку на координаты Х и У по разделительной запятой
            string[] words = stroka.Split(new char[] { ',' });
            strokaX = words[0];
            strokaY = words[1];

                //Проверяем что разобралось правильно
                //Console.WriteLine(strokaX);
                //Console.WriteLine(strokaY);

            // Конвертируем стринги в децималы (координаты) в американской культуре, а потом оно автоматом перйдет в региональную культуру
            CultureInfo cultures = new CultureInfo("en-US");

            // для Х
            decimal x = 0.0m, y=0.0m;

            try
            {
            decimal _x = System.Convert.ToDecimal(strokaX, cultures);
                x = _x;
            }
            // Обрабатываем исключениия чтобы не упасть
             catch (System.OverflowException)
            {
                System.Console.WriteLine("The conversion from string to decimal overflowed.");
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("The string is not formatted as a decimal.");
            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine("The string is null.");
            }
            // ----------End Х ---------------

            // для Y
            try
            {
               decimal _y = System.Convert.ToDecimal(strokaY, cultures);
                y = _y;
            }
            // Обрабатываем исключениия чтобы не упасть
            catch (System.OverflowException)
            {
                System.Console.WriteLine("The conversion from string to decimal overflowed.");
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("The string is not formatted as a decimal.");
            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine("The string is null.");
            }
            // ----------End Y ---------------


            System.Console.WriteLine("X: {0} Y: {1}", x, y); // Результат вывожу на экран

            System.Console.ReadLine(); // Ждем-с ... (чтобы окно не закрылось)
        }
    }
}
