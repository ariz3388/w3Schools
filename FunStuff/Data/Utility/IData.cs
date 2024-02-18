using System.Linq.Expressions;

namespace w3schools.FunStuff.Data.Utility
{
    public interface IData<T>
    {
        IEnumerable<T> Get();
        T Get(int Id);
        int Add(T item);
        T Edit(T item);
        IEnumerable<T> Search(Expression<Func<T, bool>> expression);
    }
}
