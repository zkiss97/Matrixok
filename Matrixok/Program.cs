using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixok
{
    class MatrixBill
    {
        private int[,] matrix = new int[10,10];
        private int rows;
        private int cols;

        public MatrixBill(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }

        public MatrixBill()
        {
            this.rows = 0;
            this.cols = 0;
        }

        public void Fill()
        {
            Console.WriteLine("Add meg hány sora és oszlopa lesz a mátrixnak:");
            Console.WriteLine("Sorok száma:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Oszlopok száma:");
            cols = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("\n{0}. sor elemei:", i + 1);
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("{0} sor {1} elem", i+1, j+1);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Screen()
        {
            Console.WriteLine("A megadott mátrix a következő:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MatrixBill mb1 = new MatrixBill();
            mb1.Fill();
            mb1.Screen();

            Console.ReadLine();
        }
    }
}
