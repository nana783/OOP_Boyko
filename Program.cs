using Lab_1;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter the size of square matrix: ");
        int size = Convert.ToInt32(Console.ReadLine());
        TDeterminant2 m1 = new TDeterminant2(size);
        Console.WriteLine();
        Console.WriteLine("1. Fill a matrix manually\n" +
            "2. Fill a matrix randomly");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1:
                m1.Fill();
                break;
            case 2:
                m1.FillRandom();
                break;
        }
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Your matrix:");
            m1.Show();
            Console.WriteLine();

            Console.WriteLine("1. MAX element\n" +
                "2. MIN element\n" +
                "3. SUM of all elements\n" +
                "4. Determinant\n" +
                "5. Add matrix\n" +
                "6. Subtract matrix\n");

            TSMatrix m2 = new TDeterminant2(size);
            TSMatrix m3 = new TDeterminant2(size);

            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine(m1.FindMax());
                    break;
                case 2:
                    Console.WriteLine(m1.FindMin());
                    break;
                case 3:
                    Console.WriteLine(m1.Sum());
                    break;
                case 4:
                    Console.WriteLine(m1.Determinant()); 
                    break;
                case 5:
                    m2.FillRandom();
                    Console.WriteLine("Randomly filled matrix");
                    m2.Show();
                    m3 = m1 + m2;
                    Console.WriteLine("Result:");
                    m3.Show();
                    break;
                case 6:
                    m2.FillRandom();
                    m2.Show();
                    m3 = m1 - m2;
                    Console.WriteLine("Result:");
                    m3.Show();
                    break;
            }
            Console.ReadLine();            
        }
    }
}