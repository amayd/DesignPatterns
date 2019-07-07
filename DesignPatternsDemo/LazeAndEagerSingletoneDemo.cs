using System;

namespace InterviewPreperation
{
    public sealed class LazeAndEagerSingletoneDemo
    {

        // making variable accessable only in class.
        // this is called eager loading. Remove lay keyword and it will be eager loading
        // to make it lazy loading we only need to add Lazy for creating instance
        private static readonly Lazy<LazeAndEagerSingletoneDemo> instance = new Lazy<LazeAndEagerSingletoneDemo>(()=> new LazeAndEagerSingletoneDemo());
        // provide public static property to access reference to instance of the class.
        public static LazeAndEagerSingletoneDemo GetInstance
        {
            get
            {
                // eager loading will return the readonly object created  above
                // returning instance
                // intance.Value is done in case of lazy loading. not in case of eager 
                return instance.Value;
            }
        }

        // making private contructors so instance will not be created outside of the class.
        private LazeAndEagerSingletoneDemo()
        {

        }

        // public method to be accessed outside the class.
        public void PrintDetailsFromLazeAndEagerSingletoneDemo()
        {
            Console.WriteLine("Laze And Eager Singletone Demo Public method");
        }
   }
}
