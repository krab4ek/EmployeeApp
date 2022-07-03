using EmployeeApp;

Console.WriteLine("****** The Employee Class Hierarchy *****\n");
//var emp = new EmployeeApp.Employee("Marvin", 34, 456, 6000);
//var joe = new EmployeeApp.Employee("Joe", 22, 8000);
//emp.GiveBonus(1000);
//emp.DisplayStats();
//emp.Name = "Marv";
//Console.WriteLine($"Employee is named: {emp.Name}");


SalesPerson fred = new SalesPerson();
fred.Age = 31;
fred.Name = "Fred";
fred.SalesNumber = 50;
fred.DisplayStats();
Console.WriteLine();

var chucky = new Manager("Chucky", 50, 92, 11000, "3333-999-0000", 9000);
var cost = chucky.GetBenefitCost();
chucky.GiveBonus(300);
chucky.DisplayStats();
Console.WriteLine();

var fran = new SalesPerson("Fran",23,567,6000,"888-000-999",31);
fran.GiveBonus(400);
fran.DisplayStats();

BenefitPackage.BenefitPackageLevel myLevel = BenefitPackage.BenefitPackageLevel.Gold;



Console.ReadLine();
