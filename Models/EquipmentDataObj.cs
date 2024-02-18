using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using w3schools.Managers;

namespace w3schools.Models
{
    public class EquipmentDataObj : Equipment
    {
        public bool IsEquipment { get; set; }
        public bool IsWeapon { get; set; }
        public bool IsArmor { get; set; }
        public bool IsLarge { get; set; }
        public bool IsCrown { get; set; }
        public bool IsSkull { get; set; }
        public int Def { get; set; }
        public string Dmg { get; set; }

        public EquipmentDataObj(int Id, string Name, string Description, string Type, int Cost = 1, string? D = null) : base()
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.IsEquipment = Type.ToUpper().Contains("E");
            this.IsLarge = Type.ToUpper().Contains("L");
            this.IsWeapon = Type.ToUpper().Contains("W");
            this.IsArmor = Type.ToUpper().Contains("A");
            this.IsCrown = Type.ToUpper().Contains("C");
            this.IsSkull = Type.ToUpper().Contains("S");
            this.Cost = Cost;
            if (!D.IsNumOnly() && D.Contains("|"))
            {
                var a = D.Split("|");
                this.Dmg = a[0];
                this.Def = int.Parse(a[1]);
            }
            else
            {
                this.Def = D.IsNumOnly() ? int.Parse(D) : 0;
                this.Dmg = D.IsNumOnly() ? string.Empty : D.ToUpper();
            }
        }
    }
}
