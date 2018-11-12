using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(First());
            Console.WriteLine("Введите 6-значное число: ");
            string a = Console.ReadLine();
            Console.WriteLine(Second(a));
            Third();
            Fourth(3, 7);
            Fifth(123);

            Console.ReadLine();


        }



        static int First()
        {
            Console.WriteLine("Введите строку. Нажмите \".\",чтобы закончить");
            int k = 0;
            string i = "";
            while (true)
            {
                i = Console.ReadLine();
                for (int j = 0; j < i.Length; j++)
                {
                    if (i[j] == ' ') k++;
                    if (i[j] == '.') { return k; }
                }
            }
        }
        static bool Second(string a)
        {
            int b = int.Parse(a);
            int b1 = b / 100000;
            int b2 = (b / 10000) - b1 * 10;
            int b3 = (b / 1000) - b1 * 100 - b2 * 10;
            int b4 = b % 10;
            int b5 = (b % 100 - b4) / 10;
            int b6 = (b % 1000 - b5 * 10 - b4) / 100;
            if ((b1 + b2 + b3) == (b4 + b5 + b6))
                return true;
            else return false;
        }

        static void Third()
        {
           
           
                int e, count = 0;
                char i;
            Console.WriteLine("Введите строку и точку, чтобы закончить ввод");
            e = Console.Read();

            do
                {
                    
                    do
                    {
                        e = Console.Read();
                        i = (char)e;
                    } while (i == '\n' | i == '\r');



                    if (e >= 65 && e <= 90)
                    {
                        e += 32;
                        i = (char)e;
                        Console.WriteLine(i);
                        count++;

                    }
                    else if (e >= 97 && e <= 122)
                    {
                        e -= 32;
                        i = (char)e;
                        Console.WriteLine(i);
                        count++;
                    }
                    else if (e == 46)
                    {
                        break;
                    }
                    else
                    {
                        i = (char)e;
                        Console.WriteLine(i);
                    }


                } while (e != 46);
            Console.ReadLine();


        }
    

        static void Fourth(int p1, int p2)
        {
            for (int i = p1; i <= p2; i++)
            {
                for (int k = 0, j = i; k < j; k++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine("\n");
            }
        }
        static void Fifth(int n)
        {
            int res = 0;
            while (n > 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            Console.WriteLine(res);
        }
    }
}
