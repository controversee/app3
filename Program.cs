using System;
using System.Globalization;
using System.Security.Cryptography;

namespace homeworkapp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region-Verilmiş M dəyərindən verilmiş N dəyərinədək 21 - ə bölünən ədədlərin ədədi ortasını tap
            //Console.WriteLine("Eded daxil edin:");

            //string input1 = Console.ReadLine();
            //int M = Convert.ToInt32(input1);

            //string input2 = Console.ReadLine();
            //int N = Convert.ToInt32(input2);

            //var sum = 0;
            //var count = 0;

            //for (int i = M; i < N; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        sum += i;
            //        count++;
            //    }
            //}
            //if (count != 0)
            //    Console.WriteLine(sum / count);
            //else
            //    Console.WriteLine("21-e bolunen eded yoxdur");
            #endregion

            #region-Verilmiş ədədin rəqəmləri cəmini tap
            //Console.WriteLine("Ededi daxil et:");
            //var input = Console.ReadLine();
            //int N = Convert.ToInt32(input);
            //var sum = 0;
            //while(N != 0)
            //{ 
            //    sum += N % 10;
            //    N = (N - (N % 10)) / 10;
            //}
            //Console.WriteLine(sum); 
            #endregion

            #region-Verilmiş ayın ədədinə görə hansı fəsil olduğunu tap
            //Console.WriteLine("Eded daxil edin");
            //var input = Console.ReadLine();
            //int month = Convert.ToInt32(input);
            //if (month >= 1 && month <= 12)
            //{
            //    if (month >= 3 && month <= 5)
            //    {
            //        Console.WriteLine("yazdir");
            //    }

            //    else if (month >= 6 && month <= 8)
            //    {
            //        Console.WriteLine("Yaydir");
            //    }
            //    else if (month >= 9 && month <= 11)
            //    {
            //        Console.WriteLine("payizdir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("qishdir");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("ay duzgun daxil edilmeyib");
            //}
            #endregion

            #region-Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək
            //Console.WriteLine("Yazini daxil et");
            //string text= Console.ReadLine();
            //var hasDigit = false;
            //for (int i=0; i<text.Length; i++)
            //{
            //    for (int j=0; j<text.Length; j++) 
            //    {
            //        if (Digit[j] == text[i])
            //        {
            //            hasDigit = true;
            //            break;


            //        }
            //    }

            //}if (hasDigit == true)
            //{
            //    break;
            //}
            #endregion
            #region-Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram. Misalçün consoledan 5,10 və + daxil edilsə 5 və 10-u toplayıb nəticəsini göstərsin.Console-dan daxil edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.
            //var input1 = Console.ReadLine();
            //int X = Convert.ToInt32(input1);

            //var input2 = Console.ReadLine();
            //int Y = Convert.ToInt32(input2);

            //Console.WriteLine("Operatoru daxil et:");
            //string opt = Console.ReadLine();
            //int result;

            //if (opt == "+")
            //{
            //    result = X + Y;
            //    Console.WriteLine(result);
            //}
            //else if (opt == "-")
            //{
            //    result = X - Y;
            //    Console.WriteLine(result);
            //}
            //else if (opt == "*")
            //{
            //    result = X * Y;
            //    Console.WriteLine(result);
            //}
            //else if (opt == "/")
            //    if (Y == 0)
            //    {
            //        Console.WriteLine("0-a bolme yoxdur");
            //    }
            //    else


            //    {
            //        result = X / Y;
            //        Console.WriteLine(result);
            //    }

            //else
            //{
            //    Console.WriteLine("operator yanlishdir");
            //}
            #endregion

            #region 
            int num = 21;
            var result = Increment(num);
            Console.WriteLine(result);
        }
        static int Increment(int num)
        {
            num += 1;
            return num;
        }
        #endregion

        
        }

    }





