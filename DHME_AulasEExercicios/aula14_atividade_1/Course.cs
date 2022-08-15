using Aula14Atividade1.Abstractions;

namespace Aula14Atividade1;

internal class Course : Administration<Student>
{
    private readonly Dictionary<int, Student> _students = new();

    public override bool Register(Student entity)
        => _students.TryAdd(entity.Registration, entity);

    public override bool Remove(Student entity)
        => _students.Remove(entity.Registration);

    public override bool Update(Student entity)
    {
        if (_students.ContainsKey(entity.Registration))
            return false;

        _students[entity.Registration] = entity;
        return true;
    }

    public override IReadOnlyList<Student> List()
        => _students.Values.ToArray();
}
