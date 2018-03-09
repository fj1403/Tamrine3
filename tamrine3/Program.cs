using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrine3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] intArr = new int[8];
            int input = 0;
            double probability;
            for (int i = 0; i < 8; i++)
            {
                while (input <= 0)
                {
                    Console.WriteLine("Onsore " + i.ToString() + " om arraye ra vared nemayeed:");
                    Int32.TryParse(Console.ReadLine(), out input);
                    if (input > 0)
                    {
                        intArr[i] = input;
                    }
                    else
                    {
                        Console.WriteLine("Adade vared shode motabaer nist. Lotfan mojadadan talash konid.");
                    }
                }
                input = 0;
            }
            
            while (true)
            {
                Console.WriteLine("Ehtemale entekhabe kodam adad ra mikhahid:");
                Int32.TryParse(Console.ReadLine(), out input);
                if (input == -1)
                {
                    break;
                }

                probability = calculateProbability(intArr, input);

                Console.WriteLine("Ehtemale entekhabe adade " + input + ", " + probability + " ast.");
            }
            Console.WriteLine("end");
        }
        public static double calculateProbability(int[] arr, int number)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if (item == number)
                {
                    counter += 1;
                }
            }
            return Convert.ToDouble(counter) / Convert.ToDouble(arr.Length);
        }
    }
}
