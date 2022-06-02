using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Main;

namespace CSharp_Net_module1_3_1_lab
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod()
        {
            try
            {
                MyArray ma = new MyArray();
                int[] arr = new int[4] { 1, 4, 8, 5 };
                arr[1] = 0;
                ma.Assign(arr, 4);
                arr = null;
                ma.Assign(arr, 5);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
                Console.WriteLine("Stack Trace : " + ex.StackTrace);
                Console.WriteLine("Source : " + ex.Source);
                Console.WriteLine("HelpLink : " + ex.HelpLink);
                Console.WriteLine("TargetSite : " + ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("Finally, block which will be always showed )");
            }
        }
    }
}