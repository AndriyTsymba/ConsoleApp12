using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{


    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    class Array : IMath
    {
        private int[] data;
        public Array(int[] data)
        {
            this.data = data;
        }
        public int Max()
        {
            if (data.Length == 0) throw new InvalidOperationException();
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max) max = data[i];
            }
            return max;
        }
        public int Min()
        {
            if (data.Length == 0) throw new InvalidOperationException();
            int min = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min) min = data[i];
            }
            return min;
        }
        public float Avg()
        {
            if (data.Length == 0) throw new InvalidOperationException();
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            return (float)sum / data.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == valueToSearch) return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 7, 2, 9, 5 };
            Array array = new Array(numbers);
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Avg());
            Console.WriteLine(array.Search(9));
            Console.WriteLine(array.Search(3));
        }
    }
}