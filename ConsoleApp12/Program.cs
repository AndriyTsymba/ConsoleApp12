using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    class Array : ISort
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
        public void SortAsc()
        {
            Array.Sort(data);
        }
        public void SortDesc()
        {
            Array.Sort(data);
            Array.Reverse(data);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();
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

            array.SortAsc();
            Console.WriteLine(string.Join(", ", numbers));

            array.SortDesc();
            Console.WriteLine(string.Join(", ", numbers));

            array.SortByParam(true);
            Console.WriteLine(string.Join(", ", numbers));

            array.SortByParam(false);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}