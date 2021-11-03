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
            string headerSymbol = "A B C D E F G H I J";

            Console.Write("Input size array ->");
            sizeArray = Convert.ToInt32(Console.ReadLine());
            numericArray = new int[sizeArray];
            positiveArray = new string[sizeArray];
            negativeArray = new string[sizeArray];

            // чатсть 1. Разделение на массивы.
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

            // часть 2. Замена чисел на буквы.
            SwapToAlphabet(ref positiveArray, headerSymbol);
            SwapToAlphabet(ref negativeArray, headerSymbol);

            Console.ReadKey();
        }

        private static void SwapToAlphabet(ref string[] inputArray, string headerSymbol)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < inputArray.Length; i++)
            {
                int alphabetPosition = Convert.ToInt32(inputArray[i]) - 1;
                inputArray[i] = alphabet[alphabetPosition].ToString();

                if (headerSymbol.Contains(inputArray[i], StringComparison.OrdinalIgnoreCase))
                {
                    inputArray[i] = inputArray[i].ToUpper();
                }
            }

            return;
        }
    }
}
