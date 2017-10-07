using System;

namespace Min_MaxSum
{
    internal static class Program
    {
        private static void Main()
        {
            var arrTemp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arrTemp, int.Parse);

            var firstSum = 0;
            var secondSum = 0;
            var thirdSum = 0;
            var fourthSum = 0;
            var fifthSum = 0;

            firstSum = arr[1] + arr[2] + arr[3] + arr[4];
            secondSum = arr[0] + arr[2] + arr[3] + arr[4];
            thirdSum = arr[0] + arr[1] + arr[3] + arr[4];
            fourthSum = arr[0] + arr[1] + arr[2] + arr[4];
            fifthSum = arr[0] + arr[1] + arr[2] + arr[3];
            
            if(firstSum < secondSum && firstSum < thirdSum && firstSum < fourthSum && firstSum < fifthSum)
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
