using DE.Challenge.Payslip.UnitTests.Common;

namespace DE.Challenge.Payslip.UnitTests.Domain.Entity.Employee;
public class EmployeeTestFixture : BaseFixture
{
    public EmployeeTestFixture() : base() { }

    public string GetValidEmployeeName()
    {
        return Faker.Person.FullName;
    }
}
