namespace Algorithm
{
    using System;

    public class LeetCode4
    {
        public double FindMedianSortedArrays1(int[] nums1, int[] nums2)
        {
            if (nums1 == null && nums2 == null)
            {
                throw new ArgumentNullException(nameof(nums1));
            }
            if (nums1 == null)
            {
                if (nums2.Length <= 0)
                {
                    throw new ArgumentException("the length of nums2 is less than zero");
                }
                else
                {
                    if (nums2.Length % 2 == 0)
                    {
                        return (nums2[nums2.Length / 2 - 1] + nums2[nums2.Length / 2]) / 2d;
                    }
                    else
                    {
                        return nums2[nums2.Length / 2];
                    }
                }
            }
            if (nums2 == null)
            {
                if (nums1.Length <= 0)
                {
                    throw new ArgumentException("the length of nums1 is less than zero");
                }
                else
                {
                    if (nums1.Length % 2 == 0)
                    {
                        return (nums1[nums1.Length / 2 - 1] + nums1[nums1.Length / 2]) / 2d;
                    }
                    else
                    {
                        return nums1[nums1.Length / 2];
                    }
                }
            }
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            int nums1Index = 0, nums2Index = 0, mergedArrayIndex = 0;
            while (nums1Index < nums1.Length && nums2Index < nums2.Length)
            {
                mergedArray[mergedArrayIndex++] = nums1[nums1Index] > nums2[nums2Index] ? nums2[nums2Index++] : nums1[nums1Index++];
            }

            while (nums1Index < nums1.Length)
            {
                mergedArray[mergedArrayIndex++] = nums1[nums1Index++];
            }

            while (nums2Index < nums2.Length)
            {
                mergedArray[mergedArrayIndex++] = nums2[nums2Index++];
            }

            if (mergedArray.Length % 2 == 0)
            {
                return (mergedArray[mergedArray.Length / 2 - 1] + mergedArray[mergedArray.Length / 2]) / 2d;
            }
            else
            {
                return mergedArray[mergedArray.Length / 2];
            }
        }

        public double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            if (nums1 == null && nums2 == null)
            {
                throw new ArgumentNullException(nameof(nums1));
            }
            if (nums1 == null)
            {
                if (nums2.Length <= 0)
                {
                    throw new ArgumentException("the length of nums2 is less than zero");
                }
                else
                {
                    if (nums2.Length % 2 == 0)
                    {
                        return (nums2[nums2.Length / 2 - 1] + nums2[nums2.Length / 2]) / 2d;
                    }
                    else
                    {
                        return nums2[nums2.Length / 2];
                    }
                }
            }
            if (nums2 == null)
            {
                if (nums1.Length <= 0)
                {
                    throw new ArgumentException("the length of nums1 is less than zero");
                }
                else
                {
                    if (nums1.Length % 2 == 0)
                    {
                        return (nums1[nums1.Length / 2 - 1] + nums1[nums1.Length / 2]) / 2d;
                    }
                    else
                    {
                        return nums1[nums1.Length / 2];
                    }
                }
            }

            int previousMedian = 0, median = 0, nums1Index = 0, nums2Index = 0;
            for (int i = 0; i <= (nums1.Length + nums2.Length) / 2; i++)
            {
                previousMedian = median;
                median = nums1Index < nums1.Length && (nums2Index >= nums2.Length || nums1[nums1Index] < nums2[nums2Index]) ? nums1[nums1Index++] : nums2[nums2Index++];
            }

            if ((nums1.Length + nums2.Length) % 2 == 0)
            {
                return (previousMedian + median) / 2d;
            }
            else
            {
                return median;
            }
        }

        public double FindMedianSortedArrays3(int[] nums1, int[] nums2)
        {
            if (nums1 == null && nums2 == null)
            {
                throw new ArgumentNullException(nameof(nums1));
            }
            if (nums1 == null)
            {
                if (nums2.Length <= 0)
                {
                    throw new ArgumentException("the length of nums2 is less than zero");
                }
                else
                {
                    if (nums2.Length % 2 == 0)
                    {
                        return (nums2[nums2.Length / 2 - 1] + nums2[nums2.Length / 2]) / 2d;
                    }
                    else
                    {
                        return nums2[nums2.Length / 2];
                    }
                }
            }
            if (nums2 == null)
            {
                if (nums1.Length <= 0)
                {
                    throw new ArgumentException("the length of nums1 is less than zero");
                }
                else
                {
                    if (nums1.Length % 2 == 0)
                    {
                        return (nums1[nums1.Length / 2 - 1] + nums1[nums1.Length / 2]) / 2d;
                    }
                    else
                    {
                        return nums1[nums1.Length / 2];
                    }
                }
            }
        }

        private int FindKthElement(int[] nums1, int nums1Index, int[] nums2, int nums2Index, int kth)
        {
            if (nums1Index >= nums1.Length)
            {
                return nums2[nums2Index + kth - 1];
            }
            if (nums2Index >= nums2.Length)
            {
                return nums1[nums1Index + kth - 1];
            }
               
        }
    }
}