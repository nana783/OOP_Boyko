namespace Lab_1
{
    public class TDeterminant2 : TSMatrix
    {
        private double _det;
        public TDeterminant2(int size) : base(size) { }
        public double Determinant()
        {
            if (Size == 2)
                _det = Matrix[0, 0] * Matrix[1, 1] - Matrix[1, 0] * Matrix[0, 1];
            else
                _det = 0;
            return _det;
        }
    }
}
