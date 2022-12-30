using System.Linq;

namespace LinqFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //expression query
            //var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Execution the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}