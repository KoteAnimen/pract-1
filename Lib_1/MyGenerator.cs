using System;

//Вычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10.
//Пока эта сумма не превышает некоторого К. Вывести на экран сгенерированные числа, значение суммы, и кол-во сген чисел. 
namespace Lib_1
{
    public class MyGenerator
    {
        public static void GenericAndAnswer(int limitNumber, out string g_Numbers, out int summ, out int kolNumbers)
        {
            g_Numbers = "";
            summ = 0;
            kolNumbers = 0;
            int genericNumber = 0;            
            Random rnd = new Random();
            
                while (true)
                {
                    genericNumber = rnd.Next(2, 10);                    
                    summ += genericNumber;
                    g_Numbers += genericNumber.ToString() + " ";
                    kolNumbers++;                    
                    if(summ > limitNumber)
                    {
                        g_Numbers = g_Numbers.Substring(0, g_Numbers.Length - 3);//Удаляем из стоки 3 символа
                        summ -= genericNumber;
                        kolNumbers--;
                        break;
                    }                

                }
            
        }
    }
}

