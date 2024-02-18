using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using w3schools.FunStuff.Data.CrownAndSkull;
using w3schools.Models;

namespace w3schools.Managers
{
    public class LineageManager : IManager<Lineage>
    {
        private LineageData lineageData = new LineageData();

        public Lineage GetById(int id) => lineageData.Get(id);

        public IEnumerable<Lineage> GetData() => lineageData.Get();

        public IEnumerable<Lineage> Search(Expression<Func<Lineage, bool>> expression) => lineageData.Search(expression);
    }
}
