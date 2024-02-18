using System.ComponentModel;
using w3schools.Models;

namespace w3schools.FunStuff.Data.CrownAndSkull
{
    public class FlawObj : csBaseObj
    {
        public FlawObj(int? Id, int? Points, string? Name, string? Description) : base(Id.Value, Name, Description, Points.Value)
        {

        }
    }
}
