using System.Linq.Expressions;
using w3schools.Models;

namespace w3schools.FunStuff.Data.CrownAndSkull
{
    public class HistoryData : IData<HistoryObj>
    {
        public int Add(HistoryObj item)
        {
            throw new NotImplementedException();
        }

        public HistoryObj Edit(HistoryObj item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HistoryObj> Get() => GetAll();

        public HistoryObj Get(int Id) => GetAll().FirstOrDefault(x => x.Id == Id);

        public IEnumerable<HistoryObj> Search(Expression<Func<HistoryObj, bool>> expression) => (IEnumerable<HistoryObj>)((IQueryable<HistoryObj>)GetAll()).Where(expression);

        #region Temporary Hard-Coded Data

        private List<HistoryObj> GetAll()
        {
            var list = new List<HistoryObj>();
            list.Add(new HistoryObj(1, "I Left the Cult", "Madmen and fools! I escaped the night, never to return!"));
            list.Add(new HistoryObj(2, "I Joined the Cult", "Outsiders may never understand us, but our Great Leader sees many things. My purpose was found when I joined them..."));
            list.Add(new HistoryObj(3, "Our Village was Called to Arms", "Our lord rallied my people to mighty deeds, and I gave answer, taking the oath."));
            list.Add(new HistoryObj(4, "When I found the Red Crystal", "It guides me...I can't explain how."));
            list.Add(new HistoryObj(5, "Rumors of my Lost Kin Surfaced", "For so long was I alone in this world, so when word of my family came, I set out."));
            list.Add(new HistoryObj(6, "I was Taken Prisoner", "I was very young...a nomad ever since."));
            list.Add(new HistoryObj(7, "The Fissure Split Open", "A great crack broke the land; revealing darkness below. The monsters that arose set my life in motion."));
            list.Add(new HistoryObj(8, "My Brother Disappeared", "To this day I have yet to find him."));
            list.Add(new HistoryObj(9, "The Crops Failed", "I was chosen to find the evil cause of the blight."));
            list.Add(new HistoryObj(10, "The Alderman Came", "Our town headman chose a handful of us for higher purpose. I was sent into the wide world, and never looked back."));
            list.Add(new HistoryObj(11, "We Discovered the Ruins", "The weird stones and starfallen carvings of those moldering walls changed us...posing too many questions."));
            list.Add(new HistoryObj(12, "We Went Searching for Better Fishing", "Our feet just took us too far!"));
            list.Add(new HistoryObj(13, "The Rats came Ashore", "In the chaos of folk running about, I was tossed into the w2ater and almost drowned. Since then, my days have darkened."));
            list.Add(new HistoryObj(14, "The Sky went Dark", "My mother stayed behind so that we could escape...she knew the ash clouds brought dark portents."));
            list.Add(new HistoryObj(15, "I Met these Ninnies", "I've been keeping them out of trouble ever since."));
            list.Add(new HistoryObj(16, "The Wolves Appeared", "They leave nothing alive, so we fled."));
            list.Add(new HistoryObj(17, "I was Chosen", "The runes never lie, so I seek this unknown destiny."));
            list.Add(new HistoryObj(18, "I Inherited this Jewel", "It's a humming, glowing thing. I need answers. Those I ask all seem to have a different story."));
            list.Add(new HistoryObj(19, "My Master Released Me", "I completed my training, somehow, and was sent into the wild world to become a teacher someday."));
            list.Add(new HistoryObj(20, "I Betrayed my Oath", "The limits of those close-minded folk were too much to bear. Someone had to choose the hard path. That was me."));
            return list;
        }

        #endregion
    }
}
