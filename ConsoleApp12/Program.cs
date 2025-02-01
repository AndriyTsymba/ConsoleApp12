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

    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public class ArrayClass : ICalc, IOutput2, ICalc2
    {
        private int[] array;

        public ArrayClass(int[] arr)
        {
            array = arr;
        }

        public int Less(int valueToCompare)
        {
            return array.Count(num => num < valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return array.Count(num => num > valueToCompare);
        }

        public void ShowEven()
        {
            Console.WriteLine("Парні значення масиву:");
            Console.WriteLine(string.Join(" ", array.Where(num => num % 2 == 0)));
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні значення масиву:");
            Console.WriteLine(string.Join(" ", array.Where(num => num % 2 != 0)));
        }

        public int CountDistinct()
        {
            return array.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return array.Count(num => num == valueToCompare);
        }
    }

    class Program
    {
        static void Main()
        {
            int[] testArray = { 1, 5, 8, 3, 7, 10, 2, 5, 8, 3 };
            ArrayClass arrayObj = new ArrayClass(testArray);

            int compareValue = 5;
            Console.WriteLine($"Кількість елементів менше {compareValue}: {arrayObj.Less(compareValue)}");
            Console.WriteLine($"Кількість елементів більше {compareValue}: {arrayObj.Greater(compareValue)}");

            arrayObj.ShowEven();
            arrayObj.ShowOdd();

            Console.WriteLine($"Кількість унікальних значень: {arrayObj.CountDistinct()}");
            Console.WriteLine($"Кількість значень, рівних {compareValue}: {arrayObj.EqualToValue(compareValue)}");
        }
    }
}