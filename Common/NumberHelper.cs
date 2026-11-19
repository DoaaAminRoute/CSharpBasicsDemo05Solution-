// Class Library In Same Solution Or in Different Solution
namespace Common
{
    public class NumberHelper
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
