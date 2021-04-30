using System;
using System.Data;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] sayılar = {3, 5, 2, 10, 4,6,1};
          
            
            
            int temp;          
            for (int i = 0; i <= sayılar.Length - 1; i++)
            {
                for (int j = 1; j <= sayılar.Length - 1; j++)
                {
                    if (sayılar[j] < sayılar[j - 1])
                    {
                        temp = sayılar[j-1];
                        sayılar[j-1] = sayılar[j];
                        sayılar[j] = temp;

                    }
                }
            }

            foreach (var dd in sayılar)
            {
                Console.Write(dd+" ");
            }

        
        }     
    }
}