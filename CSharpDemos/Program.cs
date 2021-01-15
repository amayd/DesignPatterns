using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDemos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region MultiThreading
            MultiThreading();
            #endregion

            #region ExntensionMethods
            extensionMethods();
            #endregion

            #region TPL
            TaskParellelLibrary();
            #endregion
            Console.ReadLine();
        }

        private static void MultiThreading()
        {
            DemoMultiThreading demoMultiThreading = new DemoMultiThreading();
            demoMultiThreading.CarManufacturersAsync();
            demoMultiThreading.DesignPatternsAsync();
        }

        private static void TaskParellelLibrary()
        {
            DemoTaskParellelLibrary demoTaskParellelLibrary = new DemoTaskParellelLibrary();
            demoTaskParellelLibrary.GetCarManufacturers();
        }

        private static void extensionMethods()
        {
            List<int> vs = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
            };
            var firstTenElements = vs.GetOrderedFirstTenIntegers();

            foreach (var item in firstTenElements)
            {
                Console.WriteLine($"element:{item}");
            }
        }
    }
}
