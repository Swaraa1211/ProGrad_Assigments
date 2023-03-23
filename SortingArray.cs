
using System.Globalization;

namespace DuplicateElementsInArray
{
    internal class SortingArray
    {
        static void Main(string[] args)
        {
            Console.Write("Array length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp, i, j;
            int[] arr1 = new int[n];
            for( i = 0; i < n; i++)
            {
                Console.Write("Element: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array1: ");
            for ( i = 0; i < n; i++)
            {
                Console.Write(" " + arr1[i]);
            }

            int[] arr2 = new int[n];
            Console.WriteLine();
            for ( i = 0; i < n; i++)
            {
                Console.Write("Element: ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array2: ");
            for ( i = 0; i < n; i++)
            {
                Console.Write(" " + arr2[i]);
            }

            int[] merge = new int[n+n];
            for(  i = 0, j = 0; i < n; i++)
            {
                merge[j++] = arr1[i];
            }
            for( i = 0; i < n; i++)
            {
                merge[j++] = arr2[i];
            }
            for(i=0; i < (n*2); i++)
            {
                for( j=i+1; j < (n*2); j++)
                {
                    if (merge[i] > merge[j])
                    {
                        temp = merge[i];
                        merge[i] = merge[j];
                        merge[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nMerged and Sorted Array:") ;
            for ( i = 0; i < n*2; i++)
            {
                Console.Write(" " + merge[i]);
            }
        }
    }
}
