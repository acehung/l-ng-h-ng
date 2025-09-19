using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_
{
    public class ArrayProcessor
    {
        private int[] arr;

        public void Input()
        {
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Mảng hiện tại:");
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
        }

        // 1. Bubble Sort
        public void BubbleSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // 2. Quick Sort
        public void QuickSort(int left, int right)
        {
            int i = left, j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j) QuickSort(left, j);
            if (i < right) QuickSort(i, right);
        }

        // 3. Linear Search
        public int LinearSearch(int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }

        // 4. Binary Search (mảng phải được sắp xếp trước)
        public int BinarySearch(int key)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        // Trả về mảng (nếu cần thao tác trong Program)
        public int[] GetArray()
        {
            return arr;
        }
    }
}


