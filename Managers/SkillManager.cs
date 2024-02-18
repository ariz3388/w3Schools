using System.Linq.Expressions;
using w3schools.FunStuff.Data.CrownAndSkull;
using w3schools.Models;

namespace w3schools.Managers
{
    public class SkillManager : IManager<Skill>
    {
        private SkillsData skillsData = new SkillsData();

        public Skill GetById(int id) => skillsData.Get(id);

        public IEnumerable<Skill> GetData() => skillsData.Get();

        public IEnumerable<Skill> Search(Expression<Func<Skill, bool>> expression) => skillsData.Search(expression);
    }
}
