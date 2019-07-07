namespace ExceptionLoggingDemo.Managers
{
    public class PermanentEmployeeManager : IEmployeeManagers
    {
        public decimal GetBonus()
        {
            return 100;
        }

        public decimal GetPay()
        {
            return 50;
        }
    }
}