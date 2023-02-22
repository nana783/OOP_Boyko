namespace Lab_1
{
    public class TSMatrix
    {
        protected int _size = 0;
        protected double[,] _matrix;
            
        public TSMatrix()
        {
            _size = 2;
            _matrix = new double[2, 2];
        }
        public TSMatrix(TSMatrix m)
        {
            _size = m._size;
            _matrix = m.Matrix;
        }
        public TSMatrix(int size)
        {
            _size = size;
            _matrix = new double[size, size];
        }        
            public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        public double[,] Matrix
        {
            get
            {
                return _matrix;
            }
            set
            {
                _matrix = value;
            }
        }
        public double FindMax()
        {
            double Max = Int32.MinValue;
            foreach (var i in _matrix)
                Max = Max < i ? i : Max;
            return Max;
        }
        public double FindMin()
        {
            double Min = Int32.MaxValue;
            foreach (var i in _matrix)
                Min = Min > i ? i : Min;
            return Min;
        }
        public double Sum()
        {
            double Sum = 0;
            foreach (var i in _matrix)
                Sum += i;
            return Sum;
        }
        public void FillRandom()
        {
            Random random = new Random();
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    _matrix[i, j] = random.Next(-50, 51);
                    //_matrix[i, j] = random.NextDouble() * 50;
        }
        public void Fill()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"Enter the value for element ({i},{j}): ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    Matrix[i, j] = value;
                }
        }
        public void Show()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                    Console.Write($"{Matrix[i, j]}\t");
                Console.WriteLine();
            }
        }
        public static TSMatrix operator +(TSMatrix m1, TSMatrix m2)
        {
            if (m1.Size != m2.Size)            
                throw new ArgumentException("Matrices must have the same dimensions.");            
            for (int i = 0; i < m1.Size; i++)
                for (int j = 0; j < m1.Size; j++)
                    m1.Matrix[i, j] += m2.Matrix[i, j];
            return m1;
        }
        public static TSMatrix operator -(TSMatrix m1, TSMatrix m2)
        {
            if (m1.Size != m2.Size)
                throw new ArgumentException("Matrices must have the same dimensions.");
            for (int i = 0; i < m1.Size; i++)
                for (int j = 0; j < m1.Size; j++)
                    m1.Matrix[i, j] -= m2.Matrix[i, j];
            return m1;
        }
    }
}
