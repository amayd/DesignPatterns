using System;
using System.IO;
using System.Text;

namespace DesignPatternsDemo
{
    public sealed class Log : ILog
    {

        // making variable accessable only in class.
        private static Log instance = null;

        // provide public static property to access reference to instance of the class.
        public static Log GetInstance
        {
            get
            {
                // if instance is null then only create a instance otherwise return existing object.
                if (instance == null)
                {
                    //creating instance
                    instance = new Log();
                }
                // returning instance
                return instance;
            }
        }

        // making private contructors so instance will not be created outside of the class.
        private Log()
        {

        }

        public void LogException(string message)
        {
            string filename = $"Exception_{DateTime.Now.ToShortDateString()}";
            string filePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\{filename}";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("---------------------------------------");
            stringBuilder.Append($" Date : {DateTime.Now.ToString()}");
            stringBuilder.Append(message);

            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.Write(stringBuilder.ToString());
                streamWriter.Flush();
            }
        }
    }
}
