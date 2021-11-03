/// <summary>
/// /
/// </summary>
namespace lection4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 0;
            int[] numericArray;
            string[] positiveArray;
            string[] negativeArray;
            int numPositive = 0;
            int numNegative = 0;

            Console.Write("Input size array ->");
            sizeArray = Convert.ToInt32(Console.ReadLine());
            numericArray = new int[sizeArray];
            positiveArray = new string[sizeArray];
            negativeArray = new string[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                numericArray[i] = new Random().Next(1, 27);
                if ((numericArray[i] % 2) == 0)
                {
                    positiveArray[numPositive] = numericArray[i].ToString();
                    numPositive++;
                }
                else
                {
                    negativeArray[numNegative] = numericArray[i].ToString();
                    numNegative++;
                }
            }

            Array.Resize(ref positiveArray, numPositive);
            Array.Resize(ref negativeArray, numNegative);

            Console.ReadKey();
        }
    }
}
