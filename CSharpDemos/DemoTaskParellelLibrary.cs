using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDemos
{
    public class DemoTaskParellelLibrary
    {
        List<string> carsManufactorers = new List<string>();
        public void GetCarManufacturers()
        {
            carsManufactorers.AddRange(new List<string>() { "Toyota", "Maruti", "Suzuki", "Honda", "Tata", "Tesla", "Kia", "Morris guarage" });
            Parallel.ForEach(carsManufactorers, carsManufactorer => Console.WriteLine($"Manufacturer:{carsManufactorer}, Thread: {Thread.CurrentThread.ManagedThreadId} "));
        }
    }
}
