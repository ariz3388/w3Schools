using System.Linq.Expressions;
using w3schools.Models;

namespace w3schools.FunStuff.Data.CrownAndSkull
{
    public class LineageData : IData<Models.Lineage>
    {
        public int Add(Lineage item)
        {
            throw new NotImplementedException();
        }

        public Lineage Edit(Lineage item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lineage> Get() => GetAll();

        public Lineage Get(int Id) => GetAll().First(x => x.Id == Id);       

        public IEnumerable<Lineage> Search(Expression<Func<Lineage, bool>> expression) => ((IQueryable<Lineage>)GetAll()).Where(expression);

        #region Temp Hard-Coded Data

        private List<Lineage> GetAll()
        {
            List<Lineage> output = new List<Lineage>();

            output.Add(new Lineage(1, "Tall, Slender Elf", "The so-called high elves are known for long ears, sharp features, and elegant limbs."));
            output.Add(new Lineage(2, "Rugged Woodland Elf", "The wood elves are almost human in appearance, save slightly pointed ears. Some even grow beards."));
            output.Add(new Lineage(3, "Elf with Regal, Flawless Presence", "One of a royal or ancient bloodline."));
            output.Add(new Lineage(4, "Muscle-Bound Elven Athlete", "A statuesque figure...defined, powerful."));
            output.Add(new Lineage(5, "Sure-Footed Stout Folk", "Some dwarves are less bulky, but have larger feet, making them skilled climbers and distance walkers."));
            output.Add(new Lineage(6, "Thick-Necked Dwarf", "Known among the stourt as 'guntrnekke,' this type is heavily muscled, with square features and a strong jaw."));
            output.Add(new Lineage(7, "Jolly, Well-Fed Dwarf", "Ah the stout folk revelers! A life of eating and drinking shows on this huggable figure."));
            output.Add(new Lineage(8, "Dark-Eyed Stout Folk", "Some dwarves spend decades underground, gaining this uncanny, colorless look in the eyes."));
            output.Add(new Lineage(9, "Towering Human", "The largest folk in the realm."));
            output.Add(new Lineage(10, "Human with Drawn, Serious Features", "A life of hardship and struggle gives gravity and presence to your expression."));
            output.Add(new Lineage(11, "Bright-Eyed Human", "The happy, optimistic folk of so many places."));
            output.Add(new Lineage(12, "Afflicted Human", "Stricken with years or injury, TagHelperServicesExtensions folk struggle on."));
            output.Add(new Lineage(13, "Furry Little Proudfoot", "The smallest of Proud Foots are whiskered from head to tow, with exaggerated front teeth and small, deep-set eyes."));
            output.Add(new Lineage(14, "Robust Proudfoot", "Reaching up to 5 feet tall, these proud folk are almost human in appearance, save the refusal to wear shoes."));
            output.Add(new Lineage(15, "Proudfoot Citizen", "Dimunitive, knobby-nosed, with floppish hair."));
            output.Add(new Lineage(16, "Lighthearted Proudfoot", "Ah, the river folk! Silly, floppy ken with large hands, gleaming and colorful eyes, and creative hairstyles."));
            output.Add(new Lineage(17, "Green Frog-Kin", "Light green folk, 4-5 feet high, who squat often."));
            output.Add(new Lineage(18, "Mottled Frog-Kin", "Spotted frog-folk, brouns and greys, thickly miscled, with a bright white throat pouch and wide-set eyes."));
            output.Add(new Lineage(19, "Frog-Kin Giant", "5 to 6 feet tall, more suited to walking than leaping."));
            output.Add(new Lineage(20, "Gold Frog-Kin", "Bright yellow skin, the smallest of the frog people."));

            return output;
        }

        #endregion
    }
}
