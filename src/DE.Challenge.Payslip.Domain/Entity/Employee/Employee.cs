using DE.Challenge.Payslip.Domain.SeedWork;
using DE.Challenge.Payslip.Domain.ValueObjects;

namespace DE.Challenge.Payslip.Domain.Entity.Employee;
public class Employee : AggregateRoot
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Cpf Cpf { get; private set; }
    public string Area { get; private set; }
    public decimal Salary { get; private set; }
    public DateTime AdmissionDate { get; private set; }
    public bool IsHealthPlan { get; private set; }
    public bool IsDentalPlan { get; private set; }
    public bool IsTransportVoucher { get; private set; }

    public Employee(Guid id, string firstName, string lastName, string cpf, string area, decimal salary, DateTime admissionDate, bool isHealthPlan, bool isDentalPlan, bool isTransportVoucher)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Cpf = new Cpf(cpf);
        Area = area;
        Salary = salary;
        AdmissionDate = admissionDate;
        IsHealthPlan = isHealthPlan;
        IsDentalPlan = isDentalPlan;
        IsTransportVoucher = isTransportVoucher;
    }

}
