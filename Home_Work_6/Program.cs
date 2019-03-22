using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Home_Work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NULL_ELEMENT = 0;
            const int FIRST_ELEMENT = 1;
            const int SECOND_ELEMENT = 2;
            const int THIRD_ELEMENT = 3;
            const int FOURTH_ELEMENT = 4;
            const int FIVE = 5;

            Random random = new Random();
            Array array = new Array(FIVE);

            array[NULL_ELEMENT] = random.Next(FIVE);
            array[FIRST_ELEMENT] = random.Next(FIVE); ;
            array[SECOND_ELEMENT] = random.Next(FIVE); ;
            array[THIRD_ELEMENT] = random.Next(FIVE); ;
            array[FOURTH_ELEMENT] = random.Next(FIVE); ;


            WriteLine("Массив после возведения в квадрат: ");
            for (int i = 0; i < array.Size; i++)
            {
                Write($"{array[i]}, ");
            }

            ReadKey();
        }
    }
}
