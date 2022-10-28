using System;

namespace LabWork9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 101; i++)//выполнение цикла, пока верно условие
            {
                if (i % 2 != 0)//проверка выполнения условия нечетности чисел
                {
                    Console.Write("{0} ", i);//вывод на консоль
                }
            }
            Console.ReadKey(); //ожидание нажатия клавиши
            return; //возврат цикла
        }
    }
}
