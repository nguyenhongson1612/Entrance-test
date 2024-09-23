namespace Task1_String_Length_Frequency
{
    public class Program
    {
        public static List<string> MostFrequentStringLengths(List<string> strings)
        {
            if (strings.Count == 0)
            {
                return strings; 
            }
            var lengths = strings.Select(s => s.Length).ToList();
            var lengthCounts = lengths.GroupBy(x => x)
                                      .ToDictionary(g => g.Key, g => g.Count());

            int maxFrequency = lengthCounts.Values.Max();
            var mostCommonLengths = lengthCounts.Where(x => x.Value == maxFrequency)
                                                .Select(x => x.Key)
                                                .FirstOrDefault();

            return strings.Where(s => mostCommonLengths == s.Length).ToList();
        }

        private static void Main(string[] args)
        {
            // Thực hiện logic trong hàm Main nếu cần
        }
    }
}