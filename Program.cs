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
            string headerSymbol = "A D E H I J";

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

            // часть 3. Подсчёт заглавных. Вывод результатов.
            int numPositiveHeader = HeaderCalc(positiveArray, headerSymbol);
            int numNegativeHeader = HeaderCalc(negativeArray, headerSymbol);

            if (numPositiveHeader > numNegativeHeader)
            {
                Console.WriteLine($"Массив с чётной нумерацией имеет больше заглавных букв. Количество -> {numPositiveHeader}");
            }
            else if (numPositiveHeader < numNegativeHeader)
            {
                Console.WriteLine($"Массив с ytчётной нумерацией имеет больше заглавных букв. Количество -> {numNegativeHeader}");
            }
            else
            {
                Console.WriteLine($"Массивы имеют равное количество заглавных букв. Количество -> {numNegativeHeader}");
            }

            Console.WriteLine($"Массив чётных чисел. Заглавные {numPositiveHeader}");
            foreach (var item in positiveArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Массив нечётных чисел. Заглавные {numNegativeHeader}");
            foreach (var item in negativeArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }

        private static int HeaderCalc(string[] inputArray, string headerSymbol)
        {
            int headerCount = 0;
            foreach (var item in inputArray)
            {
                if (headerSymbol.Contains(item))
                {
                    headerCount++;
                }
            }

            return headerCount;
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
