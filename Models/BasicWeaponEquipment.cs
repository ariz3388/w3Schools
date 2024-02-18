namespace w3schools.Models
{
    public class BasicWeaponEquipment : Equipment
    {
        public string Dmg { get; set; }

        public BasicWeaponEquipment(EquipmentDataObj equipmentDataObj) : base(equipmentDataObj) 
        {
            Dmg = equipmentDataObj.Dmg;
        }
    }
}
