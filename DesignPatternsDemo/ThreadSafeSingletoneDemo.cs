using System;

namespace InterviewPreperation
{
    public sealed class ThreadSafeSingletoneDemo
    {

        // making variable accessable only in class.
        private static ThreadSafeSingletoneDemo instance = null;
        private static readonly object threadSafetyObject = new object();
        // provide public static property to access reference to instance of the class.
        public static ThreadSafeSingletoneDemo GetInstance
        {
            get
            {
                // it will lock the current object unless object is created so no other thread will access that object creation.
                // lock is very expensive to have a transaction. so add one more check for nul check.
                // when we double checking then its calls double checked locking however it creates more complications to the singletone implentation.
                if (instance == null)
                {
                    lock (threadSafetyObject)
                    {
                        // if instance is null then only create a instance otherwise return existing object.
                        if (instance == null)
                        {
                            //creating instance
                            instance = new ThreadSafeSingletoneDemo();
                        }
                    }
                }
                // returning instance
                return instance;
            }
        }

        // making private contructors so instance will not be created outside of the class.
        private ThreadSafeSingletoneDemo()
        {

        }

        // public method to be accessed outside the class.
        public void PrintDetailsFromThreadSafeSingletoneDemo()
        {
            Console.WriteLine("SingleTone Demo Public method");
        }

        #region Why sealed keyword is important
        //creating nested class when sealed keyword in not present in singletone class then it will create multiple instance of the class.
        //public class DerivedSingleToneClass : SingletoneDemo
        //{
        // to make it work remove sealed keyword from SingletoneDemo class
        //} 
        #endregion
    }
}
