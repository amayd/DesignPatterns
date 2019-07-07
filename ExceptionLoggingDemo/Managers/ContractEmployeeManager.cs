namespace ExceptionLoggingDemo.Managers
{
    public class ContractEmployeeManager : IEmployeeManagers
    {
        public decimal GetBonus()
        {
            return 80;
        }

        public decimal GetPay()
        {
            return 20;
        }
    }
}