using DE.Challenge.Payslip.UnitTests.Common;

namespace DE.Challenge.Payslip.UnitTests.Domain.Entity.Employee;
public class EmployeeTestFixture : BaseFixture
{
    public EmployeeTestFixture() : base() { }

    public string GetValidEmployeeFirstName()
    {
        return Faker.Person.FirstName;
    }

    public string GetValidEmployeeLastName()
    {
        return Faker.Person.LastName;
    }
}
