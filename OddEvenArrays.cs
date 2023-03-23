using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGrad_Assignments
{
    internal class OddEvenArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i , j =0, k=0;
            int[] arr = new int[n];
            for(i=0; i < n; i++)
            {
                Console.Write("Element: ");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            int[] odd = new int[n];
            int[] even = new int[n];
            for(i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[j++] = arr[i];
                }
                else
                {
                    odd[k++] = arr[i];
                }
            }
            Console.WriteLine("Even Array: ");
            for(i=0; i < j; i++)
            {
                Console.Write(even[i]); 
            }
            Console.WriteLine();
            Console.WriteLine("Odd Array: ");
            for (i = 0; i < k; i++)
            {
                Console.Write(odd[i]);
            }

            /*List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for(i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    //even[j] = arr[i];
                    //j++;
                    even.Append(arr[i]);
                }
                else
                {
                    //odd[k] = arr[i];
                    //k++;
                    odd.Append(arr[i]);
                }
            }
            Console.WriteLine("Even Array: ");
            even.ForEach(ev => Console.WriteLine(ev));
            for (i = 0; i < even.Count; i++)
            {
                Console.Write(even[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Odd Array: ");
            odd.ForEach(od =>  Console.WriteLine(od));
            for (i = 0; i < odd.Count; i++)
            {
                Console.Write(odd[i]);
            }
            */
        }
    }
}
