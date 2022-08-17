namespace Aula14Atividade1.Abstractions;

public abstract class Administration<T>
{
    public abstract bool Register(T entity);
    public abstract bool Remove(T entity);
    public virtual bool Update(T entity)
    {
        throw new NotImplementedException();
    }
    public virtual IReadOnlyList<T> List()
    {
        throw new NotImplementedException();
    }
}
