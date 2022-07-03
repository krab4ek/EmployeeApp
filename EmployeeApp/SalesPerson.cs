namespace EmployeeApp
{
    internal class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
        public SalesPerson()
        {

        }
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn,
            int numbOfSales) : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }

    }
}
