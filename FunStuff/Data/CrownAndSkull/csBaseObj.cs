using w3schools.Models;

namespace w3schools.FunStuff.Data.CrownAndSkull
{
    public abstract class csBaseObj
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Points { get; set; }

        public csBaseObj(int Id,  string? Name, string? Description, int Points)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Points = Points;
        }

        public csBaseObj(HistoryObj historyObj)
        {
            this.Id = historyObj.Id;
            this.Name = historyObj.Name;
            this.Description = historyObj.Description;
            this.Points = 5;
        }

        public csBaseObj(Skill skill)
        {
            this.Id = skill.Id;
            this.Name = skill.Name;
            this.Description = skill.Description;
            this.Points = skill.Points;
        }
    }
}
