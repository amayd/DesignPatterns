using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class CollectionsAndGenerics
    {
        public void getCollections()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push("abc");
            s.Push(DateTime.Now);
            s.Contains(1);
            s.Contains("abc");

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("abc");
            q.Enqueue(DateTime.Now);
            q.Contains(1);
            q.Contains("abc");
            q.Contains(DateTime.Now);
            q.Dequeue();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "");
            hashtable.Add(2, "");
            hashtable.Add(DateTime.Now, "");

            hashtable.ContainsKey(1);
            hashtable.ContainsKey("2");

            foreach (DictionaryEntry item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("1");
            arrayList.Add(hashtable);

            int a = (int)arrayList[0];
            string aa = (string)arrayList[1];

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        public void getGenericCollections()
        {
            List<int> i = new List<int>();
            i.Add(1);
            i.Add(2);

            i.Remove(1);
            i.RemoveAt(2);
            i.RemoveAll(x => x == 1);

            var keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("1", "");
            keyValuePairs["1"] = "";
            keyValuePairs.Remove("1");

            foreach (var item in keyValuePairs)
            {

            }

            KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>();

            Stack<int> vs = new Stack<int>();

            vs.Push(1);


            Queue<int> vs1 = new Queue<int>();
            vs1.Enqueue(1);

            GenericClass<int> genericClass = new GenericClass<int>();
            genericClass.GetName(1);
        }

        
        
    }

    public class GenericClass<T> where T : struct
    {
        public T GetName(T t)
        {
            return t;
        }

    } 
}
