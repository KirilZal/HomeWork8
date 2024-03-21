using System;
using System.Drawing;

namespace HomeWork8
{
    public static class Program
    {
        public static void Print(string stroka, int color)
        {

            if (color >= 1 && color <= 4)
            {
                switch (color)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:

                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                Console.WriteLine("НЕ мае такого кольору");
                int num2 = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Введіть номер кольору (1-4):");
                    Print(stroka, num2);

                }
                while (num2 < 1 && num2 > 4);
                
            }
            Console.WriteLine(stroka,color); 
            Console.ResetColor();
        }

        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("кольори до вибору:1-Red,2-Green,3-Blue,4-Yellow");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("введіть строку ");
            string strok = Console.ReadLine();
            Print(strok, num);

        }

    }
}


    
