using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_co_ban
{
    class Program
    {
        public static void vehinhchunhatRongRuot(int n,int m)
        {
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == m || j == n || j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

        }

        public static void vehinhchunhat(int n, int m)
        {
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {              
                        Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void Hello()
        {
            string name;
            Console.Write("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("I am {0}",name);
            Console.WriteLine("xin chao {0} ban can gi ?", name);
        }

        public static int SochanSoLe(int n)
        {
            if(n % 2== 0)
            {
                Console.Write("{0} la so chan",n);
            }
            else
            {
                Console.Write("{0} la so le",n);
            }
            return n;
        }
        static void Main(string[] args)
        {

            //m = int.Parse(Console.ReadLine());

            //vehinhchunhatRongRuot(n, m);
            //Console.WriteLine();
            //vehinhchunhat(n,m);
            Hello();
            Console.WriteLine("Nhap voa so nguyen");
            int n, m;
            n = int.Parse(Console.ReadLine());
            SochanSoLe(n);
            Console.ReadKey();

        }
    }
 }


