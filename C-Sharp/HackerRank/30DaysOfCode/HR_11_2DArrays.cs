namespace HackerRank._30DaysOfCode
{
    public class HR_11_2DArrays
    {
        public static int TwoDArrays(int[][] arr)
        {
            int result = 0;

            for (int linha = 0; linha < arr.Length; linha++)
            {
                for (int coluna = 0; coluna < arr[linha].Length - 1; coluna++)
                {
                    if (coluna > 3
                    || linha > 3)
                    {
                        continue;
                    }

                    int sum = arr[linha][coluna]
                        + arr[linha][coluna + 1]
                        + arr[linha][coluna + 2]
                        + arr[linha + 1][coluna + 1]
                        + arr[linha + 2][coluna]
                        + arr[linha + 2][coluna + 1]
                        + arr[linha + 2][coluna + 2];

                    if (result < sum)
                        result = sum;
                }
            }
            return result;
        }
    }
}