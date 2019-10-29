using System.Linq;
using TestNinja.Fundamentals;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new Math();
            var result = math.GetOddNumbers(5).ToArray();
            System.Console.Write('{');
            foreach (var r in result) System.Console.Write(r+", ");
            System.Console.Write('}');
            System.Console.WriteLine();
        }
    }
}
