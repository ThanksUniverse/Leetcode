public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] array = new int[nums1.Length + nums2.Length];
        int count = 0;
        for(int i = 0; i < nums1.Length;i++)
            array[count++]=nums1[i];
        for(int i = 0; i < nums2.Length;i++)
            array[count++]=nums2[i];
        if (array.Length == 1) return array[0];
        if (array.Length == 2) return (array[0] + array[1]) / 2.0;
        for (int i=0;i<array.Length;i++)
            for(int j=0;j<array.Length;j++)
                if (array[i] < array[j])
                {
                    var tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
        double result = 0.0;
        int middle = array.Length/2;
        if (array.Length % 2 == 0)
            result = (array[middle-1] + array[middle]) / 2.0;
        else
            result = array[middle];
        return result;
    }
}