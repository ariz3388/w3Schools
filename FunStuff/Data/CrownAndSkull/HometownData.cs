using System.Linq.Expressions;
using w3schools.Models;

namespace w3schools.FunStuff.Data.CrownAndSkull
{
    public class HometownData : IData<Models.HistoryObj>
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

        public HistoryObj Get(int Id) => ((IQueryable<HistoryObj>)GetAll()).First(x => x.Id == Id);

        public IEnumerable<HistoryObj> Search(Expression<Func<HistoryObj, bool>> expression) => (IEnumerable<HistoryObj>)((IQueryable<HistoryObj>)GetAll()).Where(expression);

        #region Temporary Hard-Coded Data

        private List<HistoryObj> GetAll()
        {
            List<HistoryObj> output = new List<HistoryObj>();
            output.Add(new HistoryObj(1, "Gardenburrow, Forest Refuge", "This town was founded by elvs centuries ago as a waystation for forest caretakers and foragers. Since then, it has grown to a few hundred residents and many travelers crossing the West. To call this town home, you'll be diving into mysterious forests, a longstanding feud with frog men, tensions with dwarves, and the mists of the Emerald Narrows. Gardenburrow is an elemental place...a pilgrimage for druids and nature-folk of the realm"));
            output.Add(new HistoryObj(2, "Rivergate, Bustling Trade City", "At the geographic center point of The North Holds is the port city of Rivergate. This central location has made the ruling elite here wealthy; trading with the Stormkeeper dwarves and the abundant farms south of the River Thenne. Now that Ruinmoor has gone quiet, though, Rivergate is in crisis. To call this town home, you'll be working for desperate nobles, escorting merchant barges, or exploring the fallen walls of ancient monasteries. Rivergate is the busy hub of mankind, with all its intrigue and peril."));
            output.Add(new HistoryObj(3, "Slimshire, High Plains Outpost", "The coming of the White Bird and The Holy Order has grown this town, once a wide spot in the road to Hakburg, to new heights. Ruling here is Lord Pickins, and times have been good. Such fortune has attracted the destructive attention of goblins from the Shadow Glades, Orc raiders from the deep desert, and even the darkly dreaming influence of a mysterous entity generally referred to as the eye in the well. To call this town home, you will be confronting vampiric cults, fighting goblin skirmishers, or working to secure allies in the war with the Orcs."));
            return output;
        }

        #endregion
    }
}
