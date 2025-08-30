namespace Laes.SegundaEtapa
{
    public static class SomaDeDoisNumeros
    {
        public static int[] GetIndexes(int[] nums, int target)
        {
            int[] indexes = [];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indexes = [i, j];
                        return indexes;
                    }
                }
            }

            return indexes;
        }
    }
}
