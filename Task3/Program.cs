namespace Task3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 6, -1, 88, 7, 6 };
            int[] arr2 = null;
            int[] filter = { 6, 88, 7 };
            try
            {
                int [] result = Filter.FilterArray(arr, filter);
                Console.WriteLine("Результат фильтрации: " + string.Join(", ", result));
                int[] result2 = Filter.FilterArray(arr2, filter);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

        }
    }
}
