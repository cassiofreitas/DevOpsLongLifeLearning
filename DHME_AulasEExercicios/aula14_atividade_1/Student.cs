using System.Text;

namespace Aula14Atividade1;

internal class Student
{
    public int Registration { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public double[] Grades { get; private set; } = new double[4];

    public void Update(Student student)
    {
        Registration = student.Registration;
        Name = student.Name;
        Surname = student.Surname;
        Phone = student.Phone;
        Grades = student.Grades;
    }

    public bool SetGrade(int bimester, double grade)
    {
        if (bimester is < 1 or > 4 || grade is < 0 or > 10)
            return false;

        Grades[--bimester] = grade;
        return true;
    }

    public string ShowGrades()
    {
        var result = new StringBuilder();

        for (var index = 0; index < Grades.Length; index++)
            result.AppendLine($"{index + 1}° Bimestre / Nota {Grades[index]}");

        return result.ToString();
    }

    public bool IsApproved()
        => AverageGrade() > 6.0;

    public double AverageGrade()
    {
        var sum = 0.0;

        foreach (var grade in Grades)
            sum += grade;

        return sum / Grades.Length;
    }
}
