namespace InterviewPreperation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singletone design pattern
            SingletoneDemo singletoneDemo = SingletoneDemo.GetInstance;
            singletoneDemo.PrintDetails();



        }
    }
}
