using System.Linq.Expressions;
using w3schools.Models;

namespace w3schools.FunStuff.Data.CrownAndSkull
{
    public class SkillsData : IData<Skill>
    {
        public int Add(Skill item)
        {
            throw new NotImplementedException();
        }

        public Skill Edit(Skill item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Skill> Get()
        {
            return GetAll();
        }

        public Skill Get(int Id)
        {
            var skills = GetAll();
            return skills.Any(x => x.Id == Id) ? skills.FirstOrDefault(x => x.Id == Id) : null;
        }

        public IEnumerable<Skill> Search(Expression<Func<Skill, bool>> expression)
        {
            return ((IQueryable<Skill>)GetAll()).Where(expression);
        }

        #region Temp Hard-Coded Data

        private List<Skill> GetAll()
        {
            var list = new List<Skill>();
            list.Add(new Skill(1, "Animal Training", "Charm or induce an animal companion to perform simple actions. Can only be used with one anumal at a time."));
            list.Add(new Skill(2, "Armorer", "In arm's length of an ally, roll this skill to repair 1 damaged armor item in their inventory. On a failure, the armor is destroyed."));
            list.Add(new Skill(3, "Brawling", "Fight with fists and feet. Tow uses: 1) Roll the skill to grapple or stun a foe for 1 round. 2) Use a D6 when attacking without a weapon."));
            list.Add(new Skill(4, "Breakfall", "Half damage taken in long falls if this skill is rolled successfully."));
            list.Add(new Skill(5, "Climber", "Climb any reasonable surface with texture, holds, or crevasses."));
            list.Add(new Skill(6, "Courtier", "Roll to outwit bureaucrats or royalty."));
            list.Add(new Skill(7, "Disguise", "Take on alternate identities. More difficult with acquaintances."));
            list.Add(new Skill(8, "Evade", "Used to avoid attacks that armor cannot protect against."));
            list.Add(new Skill(9, "Faith", "The ability to call forth miracles with prayer (see Divine Magic)."));
            list.Add(new Skill(10, "Forage", "A skill used to find plants in the Herbalists' Guide."));
            list.Add(new Skill(11, "Gambling", "Cheat or overcome casino games with devious attention."));
            list.Add(new Skill(12, "Hunting", "Acquire food in natural environments, enough for a group."));
            list.Add(new Skill(13, "Investigate", "Uncover hidden information, history, or subtle facts."));
            list.Add(new Skill(14, "Jump", "Leap with uncanny agility, out-jumping the untrained by 3-fold."));
            list.Add(new Skill(15, "Knowledge", "Roll to recall details on a single topic or area of expertise."));
            list.Add(new Skill(16, "Languages", "Be fluent with a successful roll. Only spend here for languages outside what would be normal for your folk to speak."));
            list.Add(new Skill(17, "Linguist", "Discern lost or unknown language, glyphs, or writing."));
            list.Add(new Skill(18, "Lockpicking", "Disable non-magical locking devices with tools."));
            list.Add(new Skill(19, "Magic", "Used to contain infernal or unstable magic, or as a resistance to spells. Also used for wild magic and anti-magic."));
            list.Add(new Skill(20, "Medical", "Recover a crossed-off skill on yourself or an ally, with a touch. A failed roll renders that skill recoverable only by rest."));
            list.Add(new Skill(21, "Mining", "Navigate or excavate underground with perfect direction and skill."));
            list.Add(new Skill(22, "Muscle", "You have a knack for leverage, a powerful grip, and raw strength. Roll this skill to bend bars, lift the unliftable, or brace against wind."));
            list.Add(new Skill(23, "Oratory", "Fascinate or deceive with stories, bravado, and sheer charisma."));
            list.Add(new Skill(24, "Pickpocket", "Acquire small or simple items on unsuspecting targets."));
            list.Add(new Skill(25, "Profession", "Any working skill or commerce skill, its tools, and ways."));
            list.Add(new Skill(26, "Repair", "Mend as damaged weapon or item. Not usable on armor. A failed roll destroys the item. \"I think I dropped a piece...\""));
            list.Add(new Skill(27, "Resist", "You are hearty. Roll to ignore extreme cold, poison, or too many mugs of ale. Hold your breath or fight back harmful magic with Resist."));
            list.Add(new Skill(28, "Riding", "Perform daring maneuvers on horseback without penalties."));
            list.Add(new Skill(29, "Running", "Run double the distance of others, outrun pursuers in the open."));
            list.Add(new Skill(30, "Sailing", "Operate marine vessels, with appropriate crew."));
            list.Add(new Skill(31, "Scholar", "Achieve renown in a specific topic. You are published."));
            list.Add(new Skill(32, "Scout", "Find all kinds of clues, information, or traps in the immediate area."));
            list.Add(new Skill(33, "Shield Fighting", "When using a shield, roll this skill instead of Defense. Additionally, add the Defense bonus of your shield to this skill."));
            list.Add(new Skill(34, "Skinning", "Harvest a slain beast for pelt or hide in 1D4 rounds."));
            list.Add(new Skill(35, "Spell Research", "Roll to study spells with time and materials in a safe place. Gain 1 hero point per day invested thus, spendable on ly on spells."));
            list.Add(new Skill(36, "Stealth", "Go unnoticed when moving. Easier if perfectly still or hidden."));
            list.Add(new Skill(37, "Streetwise", "You know shady people and back-alley secrets."));
            list.Add(new Skill(38, "Survival", "If your heart is hit (a lethal injury) roll this skill instantly (it will be crossed off). On a success, you fight off death's embrace for 1 round."));
            list.Add(new Skill(39, "Swimming", "Swim twice as far as others. Stay under water twice as long."));
            list.Add(new Skill(40, "Take Aim", "Add a die of your attack type on the next attack you make."));
            list.Add(new Skill(41, "Tracking", "Find obscured foes in the wild."));
            list.Add(new Skill(42, "Trading", "Get more value out of trade despite hagglers, bad leverage, distractions, or scammers."));
            list.Add(new Skill(43, "Mountaineer Scout", "In mountains or underground, you have a Scout skill of 15."));

            return list;
        }

        #endregion
    }
}
