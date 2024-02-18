namespace w3schools.FunStuff.Data.CrownAndSkull
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class PurposeGenerator : IData<HistoryObj>
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

        public HistoryObj Get(int Id) => GetAll().First(x => x.Id == Id);

        public IEnumerable<HistoryObj> Search(Expression<Func<HistoryObj, bool>> expression) => (IEnumerable<HistoryObj>)Search(expression);

        #region Temporary Hard-Coded Data

        private List<HistoryObj> GetAll()
        {
            List<HistoryObj> output = new List<HistoryObj>();

            output.Add(new HistoryObj(1, "Seek and Destroy Evil-Doers", "My purpose leaves evil no quarter."));
            output.Add(new HistoryObj(2, "Simply Gather Power", "If there is such mighty arcane force in the world, why not me to weild it?"));
            output.Add(new HistoryObj(3, "Make a Mess of Things", "Who doesn't like a good jest? It's all in fun!"));
            output.Add(new HistoryObj(4, "Protect my Friends", "There is great value in the service of others."));
            output.Add(new HistoryObj(5, "Sell my Skills for Coin", "I have released the upturned nose of morality and destiny. I do jobs. I am content."));
            output.Add(new HistoryObj(6, "Have Joined the Rebellion", "Those who topple the bloated fools in power are my allies. Our lives are the weapon they cannot deflect."));
            output.Add(new HistoryObj(7, "Will Find what I Seek", "No danger is too great, no task too daunting."));
            output.Add(new HistoryObj(8, "Humbly Wander", "I ask nothing of the world, save its majesty."));
            output.Add(new HistoryObj(9, "Answer to a New Master", "My loyalties are well-earned and absolute."));
            output.Add(new HistoryObj(10, "Am Driven Mad by Nightmares", "The visions won't stop. Gods, the horrors it shows me, even in waking moments!"));
            output.Add(new HistoryObj(11, "Hear a Call from Afar", "When the twilight makes red the clouds, or a clap of thunder rings...I can hear some distant sound...beckoning."));
            output.Add(new HistoryObj(12, "Just want a Place to Call Home", "A cozy hearth and soft bed await."));
            output.Add(new HistoryObj(13, "Must Secure my Fortune", "I will not wind up in poverty and rot after all this. I need to find a true nest egg."));
            output.Add(new HistoryObj(14, "Fight to Earn My Place", "Only might deeds will earn me a seat with the elders and mentors. There must be a way..."));
            output.Add(new HistoryObj(15, "Pursue a Masterwork", "I know it is out there...the masterpiece of craft told of in legends. I will be the one to find it!"));
            output.Add(new HistoryObj(16, "Will have my Revenge", "They will pay. I will be their Angel of Death."));
            output.Add(new HistoryObj(17, "Live for the Gods' Will", "I am but a vessel, and if it be their will, they will act through me. I am but a conduit, a pilgrim."));
            output.Add(new HistoryObj(18, "Am Gainfully Employed", "I live a sensible life of honorable work. Given enough time, I'll find leisure at last."));
            output.Add(new HistoryObj(19, "Answer to No One", "I go where I please, and slay who I choose."));
            output.Add(new HistoryObj(20, "Lead my Allies to Glory", "For whatever reasons, I carry the mantle of leadership for this troop. I mean to make it amtter, and see deeds done."));
            return output;
        }

        #endregion
    }
}
