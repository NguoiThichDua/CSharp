using System;

namespace _CVDTHCN
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap Chieu Dai: ");
            double chieuDai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Chieu Rong: ");
            double chieuRong = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine);

            Console.Write(string.Format("Chu vi: ({0} + {1}) * 2 = {2}", chieuDai, chieuRong, (chieuDai+chieuRong)*2));
            Console.WriteLine(Environment.NewLine);
            Console.Write(string.Format("Dien tich: ({0} * {1}) = {2}", chieuDai, chieuRong, chieuDai * chieuRong));

            Console.ReadKey();

        }
    }
}
