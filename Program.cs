using System.Text.Json.Serialization;

namespace Task3__matrix_operations_
{
    internal class Program
    {
        public static void showArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + ",");
                }
                Console.WriteLine();
            }
        }
        public static int[,] giveArr(int row , int col)
        {
            int[,] tempArr= new int[row,col];
            for (int i = 0;i< row;i++) { 

                for (int j = 0;j < col; j++)
                {
                    Console.Write($"Index of ({i},{j}) value is:");
                    tempArr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return tempArr;

        }
        public static void matrixAddition(int[,] firstArr, int[,] secondArr)
        {
            int row1= firstArr.GetLength(0);
            int col1= firstArr.GetLength(1);
            int row2= secondArr.GetLength(0);
            int col2= secondArr.GetLength(1);
            int[,] storeArr = new int[row1, col1];
            if ((row1 == row2) &&(col1 ==col2) ) 
            { 
               for (int i = 0; i < firstArr.GetLength(0); i++)
               {
                   for (int j = 0; j < firstArr.GetLength(1); j++)
                   {
                       storeArr[i, j] = firstArr[i, j] + secondArr[i, j];
                   }
               }
                Console.WriteLine("=========================================================");
                Console.WriteLine("First and Second matrices added together successfully");
                    showArr(storeArr);
            }
            else
            {
                Console.WriteLine("First and Second matrices can not match");

            }
        }
        public static void matrixSubtraction(int[,] firstArr, int[,] secondArr)
        {
            int row1= firstArr.GetLength(0);
            int col1= firstArr.GetLength(1);
            int row2= secondArr.GetLength(0);
            int col2= secondArr.GetLength(1);
            int[,] storeArr = new int[row1, col1];
            if ((row1 == row2) &&(col1 ==col2) ) 
            { 
               for (int i = 0; i < firstArr.GetLength(0); i++)
               {
                   for (int j = 0; j < firstArr.GetLength(1); j++)
                   {
                       storeArr[i, j] = firstArr[i, j] - secondArr[i, j];
                   }
               }
                Console.WriteLine("=========================================================");
                Console.WriteLine("First and Second matrices subtract  together successfully");
                    showArr(storeArr);
            }
            else
            {
                Console.WriteLine("First and Second matrices can not match");

            }
        }
        public static void matrixMultiplication(int[,] firstArr, int[,] secondArr)
        {
            int row1 = firstArr.GetLength(0);
            int col1 = firstArr.GetLength(1);
            int row2 = secondArr.GetLength(0);
            int col2 = secondArr.GetLength(1);
            int[,] rslt = new int[row1, col2];

            if((row1 ==row2) && (col1 == col2))
            {
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        rslt[i, j] = 0;
                        for (int k = 0; k < row2; k++)
                        {
                            rslt[i, j] += firstArr[i, k] * secondArr[k, j];
                           
                        }
                    }
                }
                Console.WriteLine("=========================================================");
                Console.WriteLine("First and Second matrices Multiplication  together successfully");
                showArr(rslt);
            }else {

                Console.WriteLine("First and Second matrices can not match");

            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter row of first array:");
            int row1=int.Parse(Console.ReadLine());
            Console.Write("Enter Culomn of first array:");
            int col1 = int.Parse(Console.ReadLine());
            int[,] firstArr = giveArr(row1, col1);

            Console.Write("Enter row of Second array:");
            int row2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Culomn of Second array:");
            int col2 = int.Parse(Console.ReadLine());
            int[,] secondArr = giveArr(row2, col2);

            Console.WriteLine("================================================");
            matrixAddition(firstArr, secondArr);
            matrixSubtraction(firstArr, secondArr);
            matrixMultiplication(firstArr, secondArr);

        }
    }
}



//Console.WriteLine("============1 arr =================");
//showArr(firstArr);

//Console.WriteLine("============2 arr =================");
//showArr(secondArr);