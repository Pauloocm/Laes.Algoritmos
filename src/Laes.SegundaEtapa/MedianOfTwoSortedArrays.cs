namespace Laes.SegundaEtapa
{
    public static class MedianOfTwoSortedArrays
    {
        public static double GetMedian(int[] nums1, int[] nums2)
        {
            var mergedArray = nums1.Concat(nums2).ToArray();

            return (double)mergedArray.Sum() / mergedArray.Length;
        }
    }
}
