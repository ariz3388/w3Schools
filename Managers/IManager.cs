using System.Linq.Expressions;

namespace w3schools.Managers
{
    public interface IManager<T>
    {
        IEnumerable<T> GetData();

        T GetById(int id);

        IEnumerable<T> Search(Expression<Func<T, bool>> expression);
    }
}
