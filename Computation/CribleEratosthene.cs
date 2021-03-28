using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CribleEratosthene
{
    public class Program
    {
        public static List<int> cribleEratosthene(int number)
        {
            if (number < 2)
            {
                return new List<int>();
            }
            else
            {
                List<int> myList = new List<int>(number);
                for (int item = 2; item < number + 1; item++)
                {
                    myList.Add(item);
                }

                int i = 0;
                while (myList[i] <= Math.Sqrt(number))
                {
                    int k = 2 * myList[i];
                    while (k <= number)
                    {
                        if (myList.Contains(k))
                        {
                            myList.Remove(k);
                        }
                        k += myList[i];
                    }
                    i += 1;
                }

                return myList;
            }
        }

        public static void display(List<int> myList)
        {
            foreach (int n in myList)
            {
                Console.Write(n + "  ");
            }
        }
    }
}
