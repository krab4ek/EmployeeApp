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

var fran = new SalesPerson("Fran", 23, 567, 6000, "888-000-999", 31);
fran.GiveBonus(400);
fran.DisplayStats();

BenefitPackage.BenefitPackageLevel myLevel = BenefitPackage.BenefitPackageLevel.Gold;

Console.WriteLine();

CastingExamples();

Console.WriteLine();

object frank = new Manager();
Hexagon hex;
try
{
    hex = (Hexagon)frank;
}
catch (InvalidCastException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();

object[] things = new object[4];
things[0] = new Hexagon();
things[1] = false;
things[2] = new Manager();
things[3] = "Last thing";

foreach (object item in things)
{
    Hexagon h = item as Hexagon;
    if (h == null)
        Console.WriteLine("Item is not a hexagon");
    else
    {
        h.Draw();
    }
}

GivePromotion(fran);
GivePromotion(chucky);

static void CastingExamples()
{
    object frank = new Manager("Frank Zappa", 45, 1, 32000, "1111-11-1111", 5);
    GivePromotion((Manager)frank);
    Console.WriteLine();

    Employee moonUnit = new Manager("Pol Zwap", 56, 2, 44000, "22-222-2222", 12);
    GivePromotion(moonUnit);
    Console.WriteLine();

    SalesPerson jill = new PTSalesPerson("Jill", 32, 5, 23000, "78-8000-0008", 9);
    GivePromotion(jill);
    Console.WriteLine();

}

static void GivePromotion(Employee emp)
{
    Console.WriteLine($"{emp.Name} was promoted!");
    //if (emp is SalesPerson s)
    //{
    //    Console.WriteLine($"{emp.Name} made {s.SalesNumber} sale(s)!");
    //    Console.WriteLine();    
    //}
    //if (emp is Manager m)
    //{
    //    Console.WriteLine($"{emp.Name} had {m.StockOptions} stock options...");
    //    Console.WriteLine();
    //}

    switch (emp)
    {
        case SalesPerson s when s.SalesNumber > 5:
            Console.WriteLine($"{emp.Name} made {s.SalesNumber} sale(s)!");
            Console.WriteLine();
            break;
        case Manager m:
            Console.WriteLine($"{emp.Name} had {m.StockOptions} stock options...");
            Console.WriteLine();
            break;
        case null:
        default: break;
    }
    Console.WriteLine();


}


Console.ReadLine();
