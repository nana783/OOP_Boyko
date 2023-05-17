using System;

class Program
{
    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public static void FillMatrixRand(int[,] matrix)
    {
        Random random = new Random();

        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                matrix[i, j] = random.Next(-50, 51);
            }
        }
    }
    public static void FillRandAr(double[] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next(-50, 51);
    }
    public static void ShowAr(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write($"{array[i]}    ");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Знайти найбільше число з масиву.");
            Console.WriteLine("2. Знайти скалярний добуток двох векторів.");
            Console.WriteLine("3. Впорядкувати масив.");
            Console.WriteLine("4. Розмістити елементи парних стовпців у порядку зростання.");
            Console.WriteLine("5. Визначити кількість стовпців з нульовим елементом.");
            Console.WriteLine("6. Визначити номер рядка з найдовшою серією однакових елементів.");
            Console.Write("Введіть номер завдання: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                default:
                    Console.WriteLine("Неправильний вибір завдання.");
                    break;
            }

            Console.ReadKey();
        }
    }

    static void task1()
    {
        Console.Write("Введіть кількість чисел: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];

        FillRandAr(arr);
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();

        /*for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть число #{i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine());
        }*/

        double max = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine($"Найбільше число: {max}");
    }

    static void task2()
    {
        Console.Write("Введіть розмірність векторів: ");
        int n = int.Parse(Console.ReadLine());
        double[] x = new double[n];
        double[] y = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть координату x[{i + 1}]: ");
            x[i] = double.Parse(Console.ReadLine());
            Console.Write($"Введіть координату y[{i + 1}]: ");
            y[i] = double.Parse(Console.ReadLine());
        }

        double dotProduct = 0;

        for (int i = 0; i < n; i++)
        {
            dotProduct += x[i] * y[i];
        }

        Console.WriteLine($"Скалярний добуток: {dotProduct}");
    }


    static void task3()
    {
        Console.Write("Введіть кількість елементів масиву: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];

        FillRandAr(arr);
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();

        /*for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть елемент #{i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }*/
        SortAlgs.BubbleSort(arr);
        

        //Array.Sort(arr, (a, b) => b.CompareTo(a));

        Console.Write("Відсортований масив: ");
        ShowAr(arr);

        /*for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();*/
    }

    static void task4()
    {
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        FillMatrixRand(matrix);
        /*for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введіть елемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }*/

        for (int j = 0; j < cols; j += 2)
        {
            for (int i = 0; i < rows - 1; i++)
            {
                for (int k = i + 1; k < rows; k++)
                {
                    if (matrix[i, j] > matrix[k, j])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[k, j];
                        matrix[k, j] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Матриця з відсортованими парними стовпцями:");
        PrintMatrix(matrix);
    }

    static void task5()
    {
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        int count = 0;
        FillMatrixRand(matrix);
        /* for (int i = 0; i < rows; i++)
         {
             for (int j = 0; j < cols; j++)
             {
                 Console.Write($"Введіть елемент [{i + 1},{j + 1}]: ");
                 matrix[i, j] = int.Parse(Console.ReadLine());
             }
         }*/

        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine($"Кількість стовпців з нульовим елементом: {count}");
    }

    static void task6()
    {
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        FillMatrixRand(matrix);
        /*for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введіть елемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }*/

        int maxCount = 0;
        int rowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int count = 1;

            for (int j = 0; j < cols - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        rowIndex = i;
                    }
                    count = 1;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                rowIndex = i;
            }
        }

        if (maxCount == 1)
        {
            Console.WriteLine("У матриці немає серій однакових елементів.");
        }
        else
        {
            Console.WriteLine($"Рядок з найдовшою серією однакових елементів: {rowIndex + 1}");
        }
    }
}

