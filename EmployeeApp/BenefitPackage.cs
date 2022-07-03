namespace EmployeeApp
{
    internal class BenefitPackage
    {
        public enum BenefitPackageLevel
        {
            Standart, Gold, Platinum
        }

        public double ComputePayDeduction()
        {
            return 125.0;
        }

    }
}
