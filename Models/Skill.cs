using w3schools.FunStuff.Data.CrownAndSkull;

namespace w3schools.Models
{
    public class Skill : csBaseObj
    {
        public int Points { get; set; }


        public Skill(int Id,  string? Name, string? Description, int? Points = null) : base(Id, Name, Description, Points.Value)
        {
            
        }
    }
}
