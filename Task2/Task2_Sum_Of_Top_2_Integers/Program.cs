namespace Task2
{
    public class Program
    {
        public static int SumOfTopTwoIntegers(List<int> arr)
        {
            if (arr.Count < 2)
                throw new ArgumentException("Array must contain at least two integers");

            // Sort array and take 2 first elements
            var sortedArr = arr.OrderByDescending(x => x).Take(2).ToList();

            // return sum of 2 elements
            return sortedArr[0] + sortedArr[1];
        }

        static void Main(string[] args)
        {

        }
    }
}
