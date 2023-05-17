public class SearchAlgs
{
    public static int LinearSearch(double[] arr, double target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    public static int LinearSearchWithBarrier(double[] arr, double target)
    {
        double last = arr[arr.Length - 1];
        arr[arr.Length - 1] = target;

        int i = 0;
        while (arr[i] != target)
        {
            i++;
        }

        arr[arr.Length - 1] = last;

        if (i < arr.Length - 1 || arr[arr.Length - 1] == target)
        {
            return i;
        }

        return -1;
    }

    public static int BinarySearch(double[] arr, double target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    public static int FibonacciSearch(double[] arr, double target)
    {
        int n = arr.Length;
        int fib2 = 0;
        int fib1 = 1;
        int fib0 = fib1 + fib2;

        while (fib0 < n)
        {
            fib2 = fib1;
            fib1 = fib0;
            fib0 = fib1 + fib2;
        }

        int offset = -1;

        while (fib0 > 1)
        {
            int i = Math.Min(offset + fib2, n - 1);

            if (arr[i] < target)
            {
                fib0 = fib1;
                fib1 = fib2;
                fib2 = fib0 - fib1;
                offset = i;
            }
            else if (arr[i] > target)
            {
                fib0 = fib2;
                fib1 = fib1 - fib2;
                fib2 = fib0 - fib1;
            }
            else
            {
                return i;
            }
        }

        if (fib1 == 1 && arr[offset + 1] == target)
        {
            return offset + 1;
        }

        return -1;
    }

    public static int TranspositionSearch(double[] arr, double target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int lastMatchIndex = -1;

        while (left <= right)
        {
            int i = left;

            while (i <= right && arr[i] != target)
            {
                i++;
            }

            if (i > right)
            {
                break;
            }

            if (i != left)
            {
                // Міняємо місцями знайдений елемент і попередній елемент
                double temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }

            lastMatchIndex = i - 1;

            if (arr[i - 1] == target)
            {
                return lastMatchIndex;
            }

            left = i + 1;
        }

        return -1;
    }
}