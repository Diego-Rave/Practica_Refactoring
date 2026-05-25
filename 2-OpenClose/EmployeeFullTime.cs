namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
     

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public override decimal CalculateSalary()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        } 
    }
}