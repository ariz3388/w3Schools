namespace w3schools.Models
{
    public abstract class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }

        public Equipment(EquipmentDataObj equipmentData)
        {
            if (equipmentData != null)
            {
                Id = equipmentData.Id;
                Name = equipmentData.Name;
                Description = equipmentData.Description;
                Cost = equipmentData.Cost;
            }
        }

        public Equipment()
        {

        }
    }
}
