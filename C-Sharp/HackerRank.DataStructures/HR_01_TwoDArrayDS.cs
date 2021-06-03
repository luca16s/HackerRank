namespace HackerRank.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class HR_01_TwoDArrayDS
    {
        public static int HourglassSum(List<List<int>> arr)
        {
            int result = 0;
            var resultList = new List<int>();

            for (int linha = 0; linha < arr.Count; linha++)
            {
                for (int coluna = 0; coluna < arr[linha].Count - 1; coluna++)
                {
                    if (coluna > 3
                    || linha > 3)
                    {
                        continue;
                    }

                    result +=
                    arr[linha][coluna]
                    + arr[linha][coluna + 1]
                    + arr[linha][coluna + 2]
                    + arr[linha + 1][coluna + 1]
                    + arr[linha + 2][coluna]
                    + arr[linha + 2][coluna + 1]
                    + arr[linha + 2][coluna + 2];

                    resultList.Add(result);
                    result = 0;
                }
            }
            return resultList.Max();
        }
    }
}