Console.WriteLine("****** Fun with Encapsulation *****\n");
var emp = new EmployeeApp.Employee("Marvin", 34, 456, 6000);
var joe = new EmployeeApp.Employee("Joe", 22, 8000);
emp.GiveBonus(1000);
emp.DisplayStats();
emp.Name = "Marv";
Console.WriteLine($"Employee is named: {emp.Name}");





Console.ReadLine();
