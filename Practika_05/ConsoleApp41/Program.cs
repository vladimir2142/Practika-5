using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktila_05

{
    class Program
    {
        public static double Chek(out double doub)
        {
            bool ok = false;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out doub);
                if (!ok) Console.WriteLine("Нужно вводить действительные числа");


            } while (!ok);
            return doub;
        }
        static void Main(string[] args)
        {
            double max = -1000000000;
            Console.WriteLine("ВВедите порядок матрицы");
            int n = 0;
            bool ok = false;
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (!ok || n <= 0) Console.WriteLine("Нужно вводить целые пололжительные числа ");
            } while (!ok);
            double[,] ar = new double[n, n];
            Console.WriteLine("Введите элименты матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ar[i, j] = Chek(out double k);
                }
            }
            Console.WriteLine("Ваша матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(ar[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица по которой ищется");
            int j1 = 1;
            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < j1; j++)

                {
                    Console.Write(ar[i, j] + " ");
                }
                j1++;
                Console.WriteLine();

            }
            j1 = 1;
            if (n == 1) { max = ar[0, 0]; }
            else
            {
                for (int i = 0; i < n; i++)
                {
                   
                    for (int j = 0; j < j1; j++)

                    {
                        if (ar[i, j] > max) max = ar[i, j];
                    }
                    j1++;

                }
            }
            Console.WriteLine("Max= "+max);
            Console.Read();
        }
    }
}
        
  

