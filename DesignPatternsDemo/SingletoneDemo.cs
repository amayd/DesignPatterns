using System;

namespace InterviewPreperation
{
    public sealed class SingletoneDemo
    {

        // making variable accessable only in class.
        private static SingletoneDemo instance = null;

        // provide public static property to access reference to instance of the class.
        public static SingletoneDemo GetInstance
        {
            get
            {
                // if instance is null then only create a instance otherwise return existing object.
                if (instance == null)
                {
                    //creating instance
                    instance = new SingletoneDemo();
                }
                // returning instance
                return instance;
            }
        }

        // making private contructors so instance will not be created outside of the class.
        private SingletoneDemo()
        {

        }

        // public method to be accessed outside the class.
        public void PrintDetails()
        {
            Console.WriteLine("SingleTone Demo Public method");
        }

        #region Why sealed keyword is important
        //creating nested class when sealed keyword in not present in singletone class then it will create multiple instance of the class.
       //public class DerivedSingleToneClass : SingletoneDemo
       //{
       //    //to make it work remove sealed keyword from SingletoneDemo class
       //}
        #endregion
    }
}
