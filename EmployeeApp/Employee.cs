﻿namespace EmployeeApp
{
    internal class Employee
    {
        private string empName;
        private int empID;
        private float currPay;

        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
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
        public void GiveBonus(float amount)
        {
            currPay += amount;

        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Pay: {currPay}");
        }
    }
}
