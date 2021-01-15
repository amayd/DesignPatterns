using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemos
{
    public class DemoCollections
    {
        List<string> carsManufactorers = new List<string>();
        public void getCars()
        {
            carsManufactorers.AddRange(new List<string>() { "Toyota", "Maruti", "Suzuki", "Honda", "Tata", "Tesla", "Kia", "Morris guarage" });

            Stack s = new Stack();
            s.Push(carsManufactorers.First());
            s.Push(carsManufactorers.Last());
            s.Push(DateTime.Now);
            s.Contains(carsManufactorers.First());
            s.Contains(carsManufactorers.Last());

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Queue q = new Queue();
            q.Enqueue(carsManufactorers.First());
            q.Enqueue(carsManufactorers.Last());
            q.Enqueue(DateTime.Now);
            q.Contains(carsManufactorers.First());
            q.Contains(carsManufactorers.Last());
            q.Contains(DateTime.Now);
            q.Dequeue();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, carsManufactorers.First());
            hashtable.Add(2, carsManufactorers.Last());
            hashtable.Add(DateTime.Now, "");

            hashtable.ContainsKey(1);
            hashtable.ContainsKey(2);

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(carsManufactorers.First());
            arrayList.Add(carsManufactorers.Last());
            arrayList.Add(hashtable);

            string a = (string)arrayList[0];
            string aa = (string)arrayList[1];

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
