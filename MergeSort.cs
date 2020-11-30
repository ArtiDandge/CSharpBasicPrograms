using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class MergeSort
    {
        public static void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[7];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        public static void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
        public static void mergeMain()
        {
            
            int []numbers = new int[7];
            Console.WriteLine("Enter input for sorting");
            int len = numbers.Length;
            for (int i= 0; i < numbers.Length; i++) {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Before Merge Sort:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array After Merge Sort");
            SortMethod(numbers, 0, len - 1);
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
