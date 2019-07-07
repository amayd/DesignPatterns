using ExceptionLoggingDemo.Managers;

namespace ExceptionLoggingDemo.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManagers GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManagers returnValue = null;
            if (employeeTypeId == 1)
            {
                returnValue = new PermanentEmployeeManager();
            }
            if (employeeTypeId == 2)
            {
                returnValue = new ContractEmployeeManager();
            }

            return returnValue;
        }
    }
}