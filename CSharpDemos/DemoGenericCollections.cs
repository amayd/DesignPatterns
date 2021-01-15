using System;
using System.Collections.Generic;

namespace CSharpDemos
{
    class DemoGenericCollections
    {
        
        public void GetDesignPatterns()
        {
            var designPatterns = getDesignPatterns();
            List<string> i = new List<string>();
            i.AddRange(designPatterns["Creational"]);
            i.AddRange(designPatterns["Structural"]);
            i.AddRange(designPatterns["Behavioural"]);
           
            foreach (KeyValuePair<string,List<string>> item in designPatterns)
            {
                Console.WriteLine(item.Key);
                foreach (var it in item.Value)
                {
                    Console.WriteLine(it);
                }
            }
        }

        private Dictionary<string, List<string>> getDesignPatterns()
        {
            var designPatterns = new Dictionary<string, List<string>>();
            designPatterns.Add("Creational", new List<string>() { "SingleTone","Factory","Abstract Factory","Builder","ProtoType" });
            designPatterns.Add("Structural", new List<string>() { "Adapter", "Facade", "Bridge", "Composite", "Decorator", "Proxy","FlyWeight" });
            designPatterns.Add("Behavioural", new List<string>() { "Chain of responsibility"});

            if (designPatterns.ContainsKey("Behavioural"))
            {
                designPatterns["Behavioural"].AddRange(new List<string>(){ "Command","Iterator","Mediator","Strategy","Observer","Momento","State","Template Method","Visitor"});
            }
            return designPatterns;
        }
    }
}
