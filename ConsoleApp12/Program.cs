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

    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    public class ArrayClass : ICalc, IOutput2
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

        public void ShowEven()
        {
            Console.WriteLine("Парні значення масиву:");
            foreach (int num in array)
            {
                if (num % 2 == 0)
                    Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні значення масиву:");
            foreach (int num in array)
            {
                if (num % 2 != 0)
                    Console.Write(num + " ");
            }
            Console.WriteLine();
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

            arrayObj.ShowEven();
            arrayObj.ShowOdd();
        }
    }
}