namespace EmployeeApp
{
    internal abstract partial class Employee

    {
        protected string? empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string? empSSN;

        protected BenefitPackage empBenefits = new BenefitPackage();
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay, string ssn)
            : this(name, age, id, pay) { empSSN = ssn; }
        public Employee(string name, int age, int id, float pay)
        {
            empName = name;
            empAge = age;
            empID = id;
            currPay = pay;
        }
    }
}
