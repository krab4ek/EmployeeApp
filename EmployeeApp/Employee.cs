namespace EmployeeApp
{
    internal abstract partial class Employee
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
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;

        }

        public virtual void DisplayStats()
        {
            Console.WriteLine($"Name: \t{empName}");
            Console.WriteLine($"Age: \t{empAge}");
            Console.WriteLine($"ID: \t{empID}");
            Console.WriteLine($"Pay: \t{currPay}");
            Console.WriteLine($"SSN: \t{empSSN}");
        }
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
    }
}
