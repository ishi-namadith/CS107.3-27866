using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicle_6
{
    internal class ArrayMaker
    {
        public int[] arr;
        public void Arrmaker(int size)
        {
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter a number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0;i < arr.Length;i++)
                Console.WriteLine(arr[i]);
        }
    }
}
