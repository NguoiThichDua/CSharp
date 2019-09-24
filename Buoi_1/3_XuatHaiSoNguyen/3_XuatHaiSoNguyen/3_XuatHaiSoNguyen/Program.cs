using System;

namespace _XuatHaiSoNguyen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b;
            char ch;

            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap phep tinh: ");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(TinhToan(a,b,ch));
            Console.ReadKey();
        
            
        }

        static string TinhToan(int a, int b, char ch)
        {
            switch (ch)
            {
                case '+':
                    return "a + b = " + (a + b);
                case '-':
                    return "a - b = " + (a - b);
                case '*':
                    return "a * b = " + (a * b);
                case '/':
                    if(b != 0)
                    {
                        return "a / b = " + (a / b);
                    }
                    else
                    {
                        return "b phai khac 0";
                    }
                default:
                    return "Chi nhan + - * /";
            }

        }
    }
}
