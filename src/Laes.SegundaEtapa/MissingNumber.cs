namespace Laes.SegundaEtapa
{
    public static class MissingNumber
    {
        public static int GetMissingNumber(int[] nums)
        {
            List<int> expectedNums = [];

            int count = 0;
            for (int i = 0; i <= nums.Length; i++)
            {
                expectedNums.Add(count);
                count++;
            }

            return expectedNums.Except(nums).FirstOrDefault();
        }
    }
}
