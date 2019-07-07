using System.Threading.Tasks;

namespace InterviewPreperation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singletone design pattern
            PrintSingletoneDetailsMethod();
            #endregion

            #region Multithread Singletone design pattern

            Parallel.Invoke(
                () => PrintSingletoneDetailsMethod(),
                () => PrintSingletoneDetailsMethod2()
                );

            #endregion

        }

        private static void PrintSingletoneDetailsMethod()
        {
            SingletoneDemo singletoneDemo = SingletoneDemo.GetInstance;
            singletoneDemo.PrintDetails();
        }

        private static void PrintSingletoneDetailsMethod2()
        {
            SingletoneDemo singletoneDemo = SingletoneDemo.GetInstance;
            singletoneDemo.PrintDetails();
        }
    }
}
