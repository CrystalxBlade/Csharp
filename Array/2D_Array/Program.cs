using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        /*
        static void Main(string[] args)
        {     
            int[,] matrix = new int[3, 2];

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;
            matrix[2, 0] = 5;
            matrix[2, 1] = 6;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            -------------------------------------------------------

            int[,] matrix = new int[4, 3];

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;
            matrix[3, 0] = 10;
            matrix[3, 1] = 11;
            matrix[3, 2] = 12;

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            -------------------------------------------------------

            int[,] matrix = {{1,2,3} , {4,5,6} , {7,8,9} };

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            

            -------------------- Input 2D Matrix ---------------------

           
            Console.Write("Enter the row: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the column: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[r , c];

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Enter arr[{i} , {j}]: ");
                    arr[i , j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i , j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }


        -------------------- Find key ---------------------


        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int row = 4;
            int col = 3;

            Console.WriteLine(linearSearch(matrix, row, col, 8));

            Console.ReadLine();
        }

        static bool linearSearch(int[,] mat, int row, int col, int key)
        {
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mat[i, j] == key)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        -------------------- Input/Print with method 2D ---------------------
        

        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter columns: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[r, c];

            Input(matrix);
            Print(matrix);

            Console.ReadLine();

        }

        static void Input(int[,] matrix)
        {
            for(int i = 0;  i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{i}, {j}: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }


        -------------------- Maximum Row ---------------------
        

        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            MaxRowSum(matrix);
            Console.ReadLine();
        }

        static void MaxRowSum(int[,] matrix)
        {
            int maxSum = 0;
            int maxRow = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }

                Console.WriteLine($"Row {i} sum = {rowSum}");

                if (rowSum > maxSum)
                {
                    maxSum = rowSum;
                    maxRow = i;
                }
            }
            Console.WriteLine($"\n Max row sum is : {maxSum} at row {maxRow}");
        }



        -------------------- Maximum Column ---------------------



        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            MaxCol(matrix);

            Console.ReadLine();
        }

        static void MaxCol(int[,] matrix)
        {
            int maxSum = 0;
            int maxCol = 0;

            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                int colSum = 0;

                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    colSum += matrix[i, j];
                }

                if(colSum > maxSum)
                {
                    maxSum = colSum;
                    maxCol = j;
                }
            }
            Console.WriteLine($"Max sum is {maxSum} of {maxCol} column");
        }


        -------------------- Primary Diagonal ---------------------
        

        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Diagonal(matrix);
            Console.ReadLine();
        }

        static void Diagonal(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                }
            }
        }

        */
    }
}
