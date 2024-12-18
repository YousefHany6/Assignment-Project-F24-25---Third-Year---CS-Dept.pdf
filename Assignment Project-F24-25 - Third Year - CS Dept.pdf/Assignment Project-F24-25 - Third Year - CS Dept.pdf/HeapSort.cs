using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Project_F24_25___Third_Year___CS_Dept.pdf
{
    public static class HeapSort
    {
        public static void MaxHeapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                MaxHeapify(arr, n, largest);
            }
        }

        public static void BuildMaxHeap(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                MaxHeapify(arr, n, i);
        }

        public static void HeapSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            BuildMaxHeap(arr);
            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                MaxHeapify(arr, i, 0);
            }
        }
    }
}
