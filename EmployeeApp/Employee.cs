namespace EmployeeApp
{
    internal partial class Employee
    {

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name lenght exceeds 15 characters!");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        public void GiveBonus(float amount)
        {
            currPay += amount;

        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"Age: {empAge}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Pay: {currPay}");
        }
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
    }
}
