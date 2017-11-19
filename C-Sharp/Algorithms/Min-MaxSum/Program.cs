using System;

namespace Min_MaxSum
{
    internal static class Program
    {
        private static void Main()
        {
            var arrTemp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arrTemp, int.Parse);

            int firstSum;
            int secondSum;
            int thirdSum;
            int fourthSum;
            int fifthSum;

            firstSum = arr[1] + arr[2] + arr[3] + arr[4];
            secondSum = arr[0] + arr[2] + arr[3] + arr[4];
            thirdSum = arr[0] + arr[1] + arr[3] + arr[4];
            fourthSum = arr[0] + arr[1] + arr[2] + arr[4];
            fifthSum = arr[0] + arr[1] + arr[2] + arr[3];

            if (firstSum < secondSum && firstSum < thirdSum && firstSum < fourthSum && firstSum < fifthSum)
                Console.Write(firstSum + " ");
            else if (secondSum < firstSum && secondSum < thirdSum && secondSum < fourthSum && secondSum < fifthSum)
                Console.Write(secondSum + " ");
            else if (thirdSum < firstSum && thirdSum < secondSum && thirdSum < fourthSum && thirdSum < fifthSum)
                Console.Write(secondSum + " ");
            else if (fourthSum < firstSum && fourthSum < secondSum && fourthSum < thirdSum && fourthSum < fifthSum)
                Console.Write(fourthSum + " ");
            else if (fifthSum < firstSum && fifthSum < secondSum && fifthSum < thirdSum && fifthSum < fourthSum)
                Console.Write(fifthSum + " ");

            if (firstSum > secondSum && firstSum > thirdSum && firstSum > fourthSum && firstSum > fifthSum)
                Console.Write(firstSum);
            else if (secondSum > firstSum && secondSum > thirdSum && secondSum > fourthSum && secondSum > fifthSum)
                Console.Write(secondSum);
            else if (thirdSum > firstSum && thirdSum > secondSum && thirdSum > fourthSum && thirdSum > fifthSum)
                Console.Write(secondSum);
            else if (fourthSum > firstSum && fourthSum > secondSum && fourthSum > thirdSum && fourthSum > fifthSum)
                Console.Write(fourthSum);
            else if (fifthSum > firstSum && fifthSum > secondSum && fifthSum > thirdSum && fifthSum > fourthSum)
                Console.Write(fifthSum);
            Console.ReadLine();
        }
    }
}