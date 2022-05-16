using DE.Challenge.Payslip.Domain.SeedWork;
using DE.Challenge.Payslip.Domain.ValueObjects;

namespace DE.Challenge.Payslip.Domain.Entity.Employee;
public class Employee : AggregateRoot
{
    public string Name { get; private set; }
    public Cpf Cpf { get; set; }

    public Employee(Guid id, string name, string cpf)
    {
        Id = id;
        Name = name;
        Cpf = new Cpf(cpf);
    }
}
