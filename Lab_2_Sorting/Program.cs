using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public class SortingAlgorithm
    {
        public static int[] InsertionSort(int[] arr)
        {
            for(int j = 1; j < arr.Length; j++)
            {
                int key = arr[j];
                int i = j - 1;

                while (i >= 0 && arr[i]>key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;

                }

                arr[i + 1] = key;
            }

            return arr;
        }

        public static int[] MergeSort(int[] arr, int p, int r)
        {
            if(p<r)
            {
                int q = (p + r) / 2;

                MergeSort(arr, p, q);
                MergeSort(arr, q + 1, r);
                Merge(arr, p, q, r);
            }   
            return arr;
        }

        public static void Merge(int[] arr, int p, int q, int r)
        {
            int i, j;

            int n1 = q - p + 1;
            int n2 = r - q;

            var L = new int[n1 + 1];
            var R = new int[n2 + 1];

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + j + 1];
            }

            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;

            i = 0;
            j = 0;

            for (int k = p; k <= r; k++)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
            }
        }

    }

    class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int[] array = new int[30000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
            }

            Console.WriteLine("For InsertionSort:");
            for (int n = 100; n <= 100000; n *= 2)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int[] index = SortingAlgorithm.InsertionSort(array.Take(n).ToArray());
                stopwatch.Stop();
                Console.WriteLine("n = {0}, time taken = {1} ms", n, stopwatch.ElapsedMilliseconds);
            }

            Console.WriteLine("For MergeSort:");
            for (int n = 100; n <= array.Length; n *= 2)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int[] index = SortingAlgorithm.MergeSort(array.Take(n).ToArray(), 0, n - 1);
                stopwatch.Stop();
                Console.WriteLine("n = {0}, time taken = {1} ms", n, stopwatch.ElapsedMilliseconds);
            }
        }

    }
}