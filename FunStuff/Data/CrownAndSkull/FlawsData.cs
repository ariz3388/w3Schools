using System.Linq.Expressions;

namespace w3schools.FunStuff.Data.CrownAndSkull
{
    public class FlawsData : IData<FlawObj>
    {
        public int Add(FlawObj item)
        {
            throw new NotImplementedException();
        }

        public FlawObj Edit(FlawObj item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FlawObj> Get() => GetAll();
        

        public FlawObj Get(int Id) => GetAll().First(x => x.Id == Id);

        public IEnumerable<FlawObj> Search(Expression<Func<FlawObj, bool>> expression) => ((IQueryable<FlawObj>)GetAll()).Where(expression);

        #region Temporary Hard-Coded Data

        private List<FlawObj> GetAll()
        {
            List<FlawObj> output = new List<FlawObj>();

            output.Add(new FlawObj(1, 5, "Addict", "You have a specific vice you cannot deny. If you can't get your fix, the GM will ask for a roll vs. attrition in some form."));
            output.Add(new FlawObj(2, 5, "Aescetic", "You frown on possessions. Never exceed 5 equipment."));
            output.Add(new FlawObj(3, 5, "Ancient", "You are old! Muscle, Jump, Climber, Breakfall, and Stealth skills may not exceed 9, but you earn respect for your advanced age."));
            output.Add(new FlawObj(4, 5, "Bad Reputation", "You've done things...terrible things, and people know about it. You've done hard, broken oaths, or let someone down."));
            output.Add(new FlawObj(5, 5, "Crazy", "When faced with a difficult choice, choose randomly."));
            output.Add(new FlawObj(6, 5, "Disorganized", "Where'd you put that? WHen seeking anything but your most-used items and armor, roll 9 or less on a D20 to find it."));
            output.Add(new FlawObj(7, 5, "Drunkard", "Your drinking wavers between revelry and tomfoolery. Beer and wine drain your pockets and frustrate your friends."));
            output.Add(new FlawObj(8, 5, "Employed", "You are paid or oathsworn to a lord or employer. Disobey at your own peril!"));
            output.Add(new FlawObj(9, 5, "Greedy", "Tempted by treasure, roll 6 or less on a D20 to resist the urge."));
            output.Add(new FlawObj(10, 5, "Grudge", "You have been wronged, and hold it against an individual or group, unjustly. When you enounter them, you behave terribly."));
            output.Add(new FlawObj(11, 5, "Impetuous", "You are impatient, leaping into situations without planning or reservation. Only take action in phase 1 or 2."));
            output.Add(new FlawObj(12, 5, "Injured", "This common flaw should be taken a few times in a character's lifetime. An injury brings a -1 maximum skill inventory."));
            output.Add(new FlawObj(13, 5, "Just a Kid", "Hey, I'm just a kid! Never exceed 6 skills."));
            output.Add(new FlawObj(14, 5, "Paranoid", "What's that? You hear that? You invent your own boogie men, and sew doubt among others. NPCs will be hesitant to trust you."));
            output.Add(new FlawObj(15, 5, "Phobia", "Fear of a common thing. In its presence, no roll can succeed."));
            output.Add(new FlawObj(16, 5, "Pursued", "You have a nemesis out there...somewhere...hunting you."));
            output.Add(new FlawObj(17, 5, "Sickly", "You were born frail. Survival and Resist skills cannot exceed 9."));
            output.Add(new FlawObj(18, 5, "Stubborn", "If you make up your mind, only a D20 contest with another player or NPC will sway you."));
            output.Add(new FlawObj(19, 5, "Timid", "You'd rather let others lead. Only take action in phase 4 or 5."));
            output.Add(new FlawObj(20, 5, "Unlucky", "No matter how many rabbit's feet you carry, you have a penchant for comical mishaps and crit fail on a 16+."));

            return output;
        }

        #endregion
    }
}
