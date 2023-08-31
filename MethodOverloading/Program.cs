namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            decimal result = a + b;
            return result;
        }

        public static string Add(int a, int b, bool c)
        {
            int sum = a + b;

            if (c == true)
            {
                string result = (sum == 1 || sum == -1) ? $"{sum} dollar" : $"{sum} dollars";
                return result;
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(-3, 2, true));
        }
    }
}
