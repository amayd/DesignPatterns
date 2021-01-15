using System;
using System.Threading;

namespace CSharpDemos
{
    public class DemoMultiThreading
    {
        public void CarManufacturersAsync()
        {
            DemoCollections demoCollections = new DemoCollections();
            ThreadStart threadStart = new ThreadStart(() => demoCollections.getCars());
            Thread thread = new Thread(threadStart);
            thread.Start();
            thread.IsBackground = false;
            Console.WriteLine(thread.IsThreadPoolThread);
            Console.WriteLine(thread.ManagedThreadId);
            Console.WriteLine(thread.ThreadState);
        }

        public void DesignPatternsAsync()
        {
            DemoGenericCollections demoGenericCollections = new DemoGenericCollections();
            ThreadStart threadStart1 = new ThreadStart(() => demoGenericCollections.GetDesignPatterns());
            Thread thread1 = new Thread(threadStart1);
            thread1.Start();
            thread1.IsBackground = false;
            Console.WriteLine(thread1.IsThreadPoolThread);
            Console.WriteLine(thread1.ManagedThreadId);
            Console.WriteLine(thread1.ThreadState);
        }
    }
}
