namespace w3schools.FunStuff.Data.CrownAndSkull
{
    using System.Linq.Expressions;

    public interface IData<T>
    {
        IEnumerable<T> Get();
        T Get(int Id);
        int Add(T item);
        T Edit(T item);
        IEnumerable<T> Search(Expression<Func<T, bool>> expression);
    }
}
