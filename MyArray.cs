using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class MyArray
    {
        int[] arr;

        public void Assign(int[] arr, int size)
        {
            try
            {
                this.arr[0] = 5;
                try
                {
                    this.arr = new int[size];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        this.arr[arr.Length + 1] = 5;
                        this.arr[i] = arr[i] / arr[i + 1];
                    }
                    unchecked
                    {
                        arr[arr.Length - 1] = 1000000000 * 100;
                    }
                    arr = null;
                    arr[0] = 5;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Exception : " + ex.Message);
                    Console.WriteLine("StackTrace : " + ex.StackTrace);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't make division by zero\nException : " + ex.Message);
                Console.WriteLine("StackTrace : " + ex.StackTrace);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Operation with null objects aren't allowed\nException : " + ex.Message);
                Console.WriteLine("StackTrace : " + ex.StackTrace);
            }
        }
    }
}