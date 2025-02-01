using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    public class ArrayClass : ICalc
    {
        private int[] array;

        public ArrayClass(int[] arr)
        {
            array = arr;
        }
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num < valueToCompare)
                    count++;
            }
            return count;
        }
        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num > valueToCompare)
                    count++;
            }
            return count;
        }
    }
    class Program
    {
        static void Main()
        {
            int[] testArray = { 1, 5, 8, 3, 7, 10, 2 };
            ArrayClass arrayObj = new ArrayClass(testArray);

            int compareValue = 5;
            Console.WriteLine($"Кількість елементів менше {compareValue}: {arrayObj.Less(compareValue)}");
            Console.WriteLine($"Кількість елементів більше {compareValue}: {arrayObj.Greater(compareValue)}");
        }
    }
}