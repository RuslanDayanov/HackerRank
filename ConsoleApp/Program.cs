namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SparseArraysFunc();
        }

        private static void ArrayManipulationFunc()
        {
            var arrayManipulation = new ArrayManipulation();
            arrayManipulation.Execute();
        }

        private static void SparseArraysFunc()
        {
            var sparseArrays = new SparseArrays();
            sparseArrays.Execute();
        }
    }
}
