using System;

public static class SortAlgs
{
    public static void BubbleSort(double[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    double temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void SelectionSort(double[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            double temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    public static void InsertionSort(double[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            double key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    public static void QuickSort(double[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);
        }
    }

    private static int Partition(double[] arr, int left, int right)
    {
        double pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                double temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        double temp2 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp2;
        return i + 1;
    }

    public static void ShellSort(double[] arr)
    {
        int n = arr.Length;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                double temp = arr[i];
                int j = i;
                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }
                arr[j] = temp;
            }
            gap /= 2;
        }
    }

    public static void HeapSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
        for (int i = n - 1; i >= 0; i--)
        {
            double temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            Heapify(arr, i, 0);
        }
    }
    private static void Heapify(double[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            double temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;
            Heapify(arr, n, largest);
        }
    }

    public static void HoareSort(double[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = HoarePartition(arr, left, right);
            HoareSort(arr, left, pivotIndex);
            HoareSort(arr, pivotIndex + 1, right);
        }
    }

    private static int HoarePartition(double[] arr, int left, int right)
    {
        double pivot = arr[left];
        int i = left - 1;
        int j = right + 1;
        while (true)
        {
            do
            {
                i++;
            } while (arr[i] < pivot);

            do
            {
                j--;
            } while (arr[j] > pivot);

            if (i >= j)
            {
                return j;
            }

            double temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

