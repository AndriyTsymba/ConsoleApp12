using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }
    public class Array : IOutput
    {
        private int[] _arr;

        public Array(int[] arr)
        {
            _arr = arr;
        }
        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (var item in _arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("Елементи масиву:");
            foreach (var item in _arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            int[] numbers = { 1, 2, 3, 4, 5 };
            IOutput array = new Array(numbers);
            array.Show();
            array.Show("Це масив цілих чисел:");
        }
    }
}