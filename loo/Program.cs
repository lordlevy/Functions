namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Innan funtionen");
            MyFunction();
            MyFunction();
            Console.WriteLine("Efter funtionen");
        }

        public static void MyFunction()
        {
            Console.WriteLine("Inuti en function");
        }
    }
}