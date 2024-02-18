namespace w3schools.Models
{
    public class BasicArmorEquipment : Equipment
    {
        public int Def { get; set; }

        public BasicArmorEquipment(EquipmentDataObj dataObj)  : base(dataObj)
        {
            Def = dataObj.Def;
        }
    }
}
