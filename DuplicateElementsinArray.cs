namespace DuplicateElementsInArray
{
    internal class DuplicateElementsinArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Elements in an Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int c = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter Element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                for (int j =i+1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        c++;
                        break;
                    }
                }
            }
            Console.WriteLine("Number of Duplicate Elements: " + c);
        }
    }
}