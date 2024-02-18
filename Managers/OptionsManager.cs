using Microsoft.AspNetCore.Mvc.Formatters;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using w3schools.FunStuff.Data.CrownAndSkull;

namespace w3schools.Managers
{
    public class OptionsManager 
    {
        public string Get(string key, int selectedId = -1, bool addRandom = false)
        {
            string output = "<option value='-1'" + (selectedId == -1 ? " selected" : "") + ">Please Select...</option>";
            output += (addRandom ? "<option value='R'>Random Choice</option>" : "");

            if (string.IsNullOrEmpty(key)) return output;

            switch(key.ToUpper())
            {
                case "SKILLS": return output += GetSkillsOutput(selectedId);
                case "LINEAGE": return output += GetLineageOutput(selectedId);
                case "GEQUIPMENT": return output += GetGeneratedEquipmentOutput(selectedId); // Custom list for character generator
                case "EQUIPMENT": return output += GetBasicEquipmentOutput(selectedId);
                case "WEAPON": return output += GetBasicWeaponsOutput(selectedId);
                case "ARMOR": return output += GetBasicArmorsOutput(selectedId);
                case "LARGE": return output += GetLargeEquipmentOutput(selectedId);
                case "CEQUIPMENT": return output += GetCrownEquipmentOutput(selectedId);
                case "CWEAPON": return output += GetCrownWeaponsOutput(selectedId);
                case "CARMOR": return output += GetCrownArmorsOutput(selectedId);
                case "SEQUIPMENT": return output += GetSkullEquipmentOutput(selectedId);
                case "SWEAPON": return output += GetSkullWeaponsOutput(selectedId);
                case "SARMOR": return output += GetSkullArmorsOutput(selectedId);
                case "PAST": return output += GetPastOutput(selectedId);
                case "PURPOSE": return output += GetPurposeOutput(selectedId);
                case "FLAW": return output += GetFlawOutput(selectedId);
            }          

            return output;
        }

        /// <summary>
        /// Builds option html element based on passed parameters.
        /// </summary>
        /// <param name="Id">Numeric value to put into value attribute.</param>
        /// <param name="Name">Text value to put into the display area for option element.</param>
        /// <param name="Desc">Text value to put into the title attribute; used for tool-tips</param>
        /// <param name="selectedId">Id of the option that should be pre-selected. Defaults to -1, or Please Select...</param>
        /// <returns>String containing html-generate options for a select element.</returns>
        private string GenerateOption(int Id, string Name, string Desc, int selectedId)
        {
            return "<option value='" + Id + "'" + (selectedId == Id ? " selected" : "") + " title='" + Desc + "'>" + Name + "</option>";
        }

        private string ConvertItemToOption(csBaseObj csBaseObj, int selectedId) => GenerateOption(csBaseObj.Id, csBaseObj.Name, csBaseObj.Description, selectedId);


        private string GetFlawOutput(int selectedId)
        {
            string options = string.Empty;
            FlawsData flawsData = new FlawsData();
            foreach (var item in flawsData.Get()) options += ConvertItemToOption(item, selectedId);
            return options;
        }

        
        private string GetPurposeOutput(int selectedId)
        {
            string options = string.Empty;
            PurposeGenerator generator = new PurposeGenerator();
            foreach (var item in generator.Get()) options += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return options;
        }

        private string GetPastOutput(int selectedId)
        {
            HistoryData gd = new HistoryData();
            string output = string.Empty;
            foreach (var item in gd.Get()) output += ConvertItemToOption(item, selectedId);
            return output;
        }

        private string GetSkillsOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.SkillsData sd = new FunStuff.Data.CrownAndSkull.SkillsData();
            string output = string.Empty;
            foreach (var item in sd.Get()) output += ConvertItemToOption(item, selectedId);
            return output;
        }

        private string GetLineageOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.LineageData ld = new FunStuff.Data.CrownAndSkull.LineageData();
            string output = string.Empty;
            foreach (var item in ld.Get()) output += ConvertItemToOption(item, selectedId);
            return output;
        }

        private string GetBasicEquipmentOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.BasicEquipmentData bed = new FunStuff.Data.CrownAndSkull.EquipmentData.BasicEquipmentData();
            string output = string.Empty;

            foreach (var item in bed.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetGeneratedEquipmentOutput(int selectedId)
        {
            // For getting character generator basic equipment
            string output = string.Empty;

            output += GenerateOption(1, "Axes and Hammers", "You prefer the heft and balance of headed weapons, and their crushing and chopping fighting style.", selectedId);
            output += GenerateOption(2, "Armor from Head to Toe", "With a skilled fir, perfectly comfortable.", selectedId);
            output += GenerateOption(3, "A Single, Huge Weapon", "You have eschewed versatility in favor of specialization. You and your weapon are one. A focused fighter.", selectedId);
            output += GenerateOption(4, "Tools and Gadgets", "You are outfitted with belts and pouches with all manner of implements and handy doo-dads.", selectedId);
            output += GenerateOption(5, "Mining Gear", "A simple kit for the pragmatic delver.", selectedId);
            output += GenerateOption(6, "Little More than Robes", "Clutter and encumbrance is bothersome.", selectedId);
            output += GenerateOption(7, "Bow and Arrow", "You are an archer through and through. You may carry a backup, smaller bow, or extra quiver, but seldom need it.", selectedId);
            output += GenerateOption(8, "A Steel Shield", "Not your only gear, but your closest ally in a pinch.", selectedId);
            output += GenerateOption(9, "Vials and Magical Baubles", "You revel in oddities, artifacts, ingredients, trinkets, curios, wands, and jewelry.", selectedId);
            output += GenerateOption(10, "Grimoire and Staff", "You carry a hefty spell book and twisted stick.", selectedId);
            output += GenerateOption(11, "A Mighty Spear", "Learned in a military fighting style, you prefer the reach, piercing, and versatility of a 10-foot spear, halbert, or bill hook.", selectedId);
            output += GenerateOption(12, "Fishing Pole, Paddle, and Net", "So few things in this world can you trust...swords, magic, beasts? No. But these? These you can trust.", selectedId);
            output += GenerateOption(13, "Lightweight Cloak and Quiet Boots", "Soft materials for stealth.", selectedId);
            output += GenerateOption(14, "Chainmail and Emblazoned Tabard", "The armor kit of a soldier.", selectedId);
            output += GenerateOption(15, " Many-Pocketed Great-Cloak", "Your odd interests make this critical.", selectedId);
            output += GenerateOption(16, "Armor from the Marsh Lands", "You possess a suit of protective gear from the frog empire: slat plates, leather ties, gunomo undercoat.", selectedId);
            output += GenerateOption(17, "A Bold-Crested Helm", "Walk tall with a high-topped steel helmet, horsehair crest, top spike, or bannered brim.", selectedId);
            output += GenerateOption(18, "Charms and Holy Symbols", "You carry a collection of beads, vestments, and blessed objects that invoke feelings of divinity.", selectedId);
            output += GenerateOption(19, "Flintlock Guns and Kit", "Black powder weapons are your specialty.", selectedId);
            output += GenerateOption(20, "Froggish Weapons", "The curved blades, flexible steel, red-laquer hafts, and brass guards of frog-folk blades are your preferred equipment.", selectedId);

            return output;
        }

        private string GetBasicWeaponsOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.BasicWeaponsData wed = new FunStuff.Data.CrownAndSkull.EquipmentData.BasicWeaponsData();
            string output = string.Empty;

            foreach (var item in wed.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetBasicArmorsOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.BasicArmorData bad = new FunStuff.Data.CrownAndSkull.EquipmentData.BasicArmorData();
            string output = string.Empty;   

            foreach (var item in bad.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetLargeEquipmentOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.LargeEquipmentData led = new FunStuff.Data.CrownAndSkull.EquipmentData.LargeEquipmentData();
            string output = string.Empty;

            foreach (var item in led.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetCrownEquipmentOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.CrownEquipmentData ced = new FunStuff.Data.CrownAndSkull.EquipmentData.CrownEquipmentData();
            string output = string.Empty;

            foreach (var item in ced.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetCrownWeaponsOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.CrownWeaponData cwd = new FunStuff.Data.CrownAndSkull.EquipmentData.CrownWeaponData();
            string output = string.Empty;

            foreach (var item in cwd.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }
        private string GetCrownArmorsOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.CrownArmorData cad = new FunStuff.Data.CrownAndSkull.EquipmentData.CrownArmorData();
            string output = string.Empty;

            foreach (var item in cad.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetSkullEquipmentOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.SkullEquipmentData sed = new FunStuff.Data.CrownAndSkull.EquipmentData.SkullEquipmentData();
            string output = string.Empty;

            foreach (var item in sed.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetSkullWeaponsOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.SkullWeaponData swd = new FunStuff.Data.CrownAndSkull.EquipmentData.SkullWeaponData();
            string output = string.Empty;
            foreach (var item in swd.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }

        private string GetSkullArmorsOutput(int selectedId)
        {
            FunStuff.Data.CrownAndSkull.EquipmentData.SkullArmorData sad = new FunStuff.Data.CrownAndSkull.EquipmentData.SkullArmorData();
            string output = string.Empty;
            foreach (var item in sad.Get()) output += GenerateOption(item.Id, item.Name, item.Description, selectedId);
            return output;
        }
    }
}
