using Aula14Atividade1.Abstractions;

namespace Aula14Atividade1;

internal class Company : Administration<Employee>
{
    public override bool Register(Employee entity)
    {
        throw new NotImplementedException();
    }

    public override bool Remove(Employee entity)
    {
        throw new NotImplementedException();
    }

    public override bool Update(Employee entity)
    {
        throw new NotImplementedException();
    }

    public override IReadOnlyList<Employee> List()
    {
        throw new NotImplementedException();
    }
}
