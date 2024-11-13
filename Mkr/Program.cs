namespace Mkr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..", @"..", @"..", "input.txt");

                string[] lines = File.ReadLines(filePath).Take(2).ToArray();

                if (lines.Length < 2)
                {
                    throw new ArgumentException("The file must contain two lines: the number of days and the prices.");
                }

                int days = DocumentUtils.ParseAndValidateNumber(lines[0]);
                if (days < 1 || days > 100)
                {
                    throw new ArgumentException("The number of days is incorrect.");
                }

                int[] prices = DocumentUtils.ParseAndValidateLine(lines[1]);

                if (prices.Length != days)
                {
                    throw new ArgumentException("The number of prices does not match the number of days.");
                }

                int maxPrice = 100;
                if (prices.Any(price => price > maxPrice))
                {
                    throw new ArgumentException("The price of each day shouldn't be more than 100.");
                }

                int result = ProfitUtils.GetMaxProfit(prices);

                File.WriteAllText("output.txt", result.ToString());

                Console.WriteLine("Data successfully processed and written to output.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
