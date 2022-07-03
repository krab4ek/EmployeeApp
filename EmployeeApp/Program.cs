using EmployeeApp;

Console.WriteLine("****** The Employee Class Hierarchy *****\n");
var emp = new EmployeeApp.Employee("Marvin", 34, 456, 6000);
var joe = new EmployeeApp.Employee("Joe", 22, 8000);
emp.GiveBonus(1000);
emp.DisplayStats();
emp.Name = "Marv";
Console.WriteLine($"Employee is named: {emp.Name}");


SalesPerson fred = new SalesPerson();
fred.Age = 31;
fred.Name = "Fred";
fred.SalesNumber = 50;

Console.WriteLine();



Console.ReadLine();
