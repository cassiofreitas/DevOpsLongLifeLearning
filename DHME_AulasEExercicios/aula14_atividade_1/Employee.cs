namespace Aula14Atividade1;

internal class Employee
{
    public string Name { get; set; }     
    public string Surname { get; set; }
    public string Phone { get; set; }
    public decimal Wage { get; set; }
    public string CPF { get; set; }

    public bool IsActive()
        => Wage > 0;
}
