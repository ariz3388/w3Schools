namespace w3schools.FunStuff.Data.CrownAndSkull
{
    using Models;
    using System.Linq.Expressions;
    using System.Reflection.Metadata.Ecma335;

    public static class EquipmentRawData
    {
        public static List<EquipmentDataObj> Get()
        {
            return GetAll();
        }

        public static EquipmentDataObj Get(int Id)
        {
            return GetAll().First(x => x.Id == Id);
        }

        public static List<EquipmentDataObj> Search(Expression<Func<EquipmentDataObj, bool>> expression)
        {
            return ((IQueryable<EquipmentDataObj>)GetAll()).Where(expression).ToList();
        }

        #region Temporary Hard-Coded Data

        private static List<EquipmentDataObj> GetAll()
        {
            List<EquipmentDataObj> output = new List<EquipmentDataObj>();

            output.Add(new EquipmentDataObj(1, "Backpack", "Carry 2 additional items.", "E", 6));
            output.Add(new EquipmentDataObj(2, "Torches", "3 count, snap-light, burns for 1 scene.", "E"));
            output.Add(new EquipmentDataObj(3, "Climbing Gear", "Ignore penalties on Climbing rolls.", "E"));
            output.Add(new EquipmentDataObj(4, "Mining Kit", "Exploring or excavation times cut in half.", "E"));
            output.Add(new EquipmentDataObj(5, "Cold Weather Fur", "Ignore penalties from normal cold or snow.", "E"));
            output.Add(new EquipmentDataObj(6, "Diving Gear", "2 dive helms, spearguns, fins, marker buoy.", "E"));
            output.Add(new EquipmentDataObj(7, "Lockpicks", "Cannot pick locks without these tools.", "E"));
            output.Add(new EquipmentDataObj(8, "Sack of Bearings", "A pouch of 3 dozen metal balls.", "E"));
            output.Add(new EquipmentDataObj(9, "Flint & Steel", "Camp with comfort by starting a cozy fire.", "E"));
            output.Add(new EquipmentDataObj(10, "Scribe's Kit", "Parchment book and charcoal sticks.", "E"));
            output.Add(new EquipmentDataObj(11, "Craftsman's Tools", "Hammer, spanner, and bits for simple work.", "E"));
            output.Add(new EquipmentDataObj(12, "Bandage Kit", "3 count, heal 1 crossed off skill.", "E", 3));
            output.Add(new EquipmentDataObj(13, "Oil Flask", "3 count, flammable liquid, glass phial.", "E"));
            output.Add(new EquipmentDataObj(14, "Rope", "50 foot length, breaks on crit fail usage.", "E"));
            output.Add(new EquipmentDataObj(15, "Iron Chain", "15 foot length, all but unbreakable.", "E"));
            output.Add(new EquipmentDataObj(16, "Snare Kit", "3 count, catch small animals.", "E"));
            output.Add(new EquipmentDataObj(17, "Bear Trap", "1 count, Muscle to escapte.", "E", 2));
            output.Add(new EquipmentDataObj(18, "Caltrops", "3 uses, spiked floor-scatter, inflicts D4.", "E"));
            output.Add(new EquipmentDataObj(19, "Powder Kit", "1 Firearm never empty, ruined if wet.", "E", 3));
            output.Add(new EquipmentDataObj(20, "Blessed Water", "3 uses, anathema to pure evil or the undead.", "E", 3));
            output.Add(new EquipmentDataObj(21, "Horse", "Transports 2 people at 4x walking speed.", "L", 5));
            output.Add(new EquipmentDataObj(22, "Cart", "Holds crates and barrels filled with goods.", "L", 10));
            output.Add(new EquipmentDataObj(23, "Wagon", "Transports like a cart, at horse speed.", "L", 20));
            output.Add(new EquipmentDataObj(24, "War Wagon", "An armored wagon for siege.", "L", 25));
            output.Add(new EquipmentDataObj(25, "Small Boat", "Holds 4 people, barely seaworthy, sneaky.", "L", 15));
            output.Add(new EquipmentDataObj(26, "Mast Ship", "Crew of 3 required. 2 masts, huge hold.", "L", 35));
            output.Add(new EquipmentDataObj(27, "House", "A cozy place to live, deed for life.", "L", 50));
            output.Add(new EquipmentDataObj(28, "Fort or Garrison", "A wooden Defense position with pole-fences.", "L", 75));
            output.Add(new EquipmentDataObj(29, "Castle", "A series of keeps and towers, stone.", "L", 200));
            output.Add(new EquipmentDataObj(30, "Fortress", "A massive, impregnable castle on a cliff.", "L", 300));
            output.Add(new EquipmentDataObj(31, "Dagger", "Conceal, thrown.", "W", 1, "D4"));
            output.Add(new EquipmentDataObj(32, "Walking Staff", "Handy for all kinds of things.", "W", 1, "D4"));
            output.Add(new EquipmentDataObj(33, "Short Sword", "Use with no hindrance in tight spaces.", "W", 1, "D6"));
            output.Add(new EquipmentDataObj(34, "Long Sword", "If max damage, roll again.", "W", 2, "D6"));
            output.Add(new EquipmentDataObj(35, "Great Sword", "Uses 2 hands.", "W", 3, "D10"));
            output.Add(new EquipmentDataObj(36, "Wood Axe", "Thrown, double damage on wood.", "W", 1, "D6"));
            output.Add(new EquipmentDataObj(37, "Battle Axe", "Ignore 2 target DEF", "W", 5, "D12"));
            output.Add(new EquipmentDataObj(38, "Pick Hammer", "Reduce target armor by 1 per hit.", "W", 2, "D6"));
            output.Add(new EquipmentDataObj(39, "War Hammer", "If 7+ dmg, stun for D6 phases.", "W", 3, "D8"));
            output.Add(new EquipmentDataObj(40, "Studded Mace", "If max damage, stun target 3 phases.", "W", 2, "D8"));
            output.Add(new EquipmentDataObj(41, "Spiked Flail", "Double dmg if used mounted.", "W", 3, "D10"));
            output.Add(new EquipmentDataObj(42, "Spear", "Thrown, long reach.", "W", 2, "D8"));
            output.Add(new EquipmentDataObj(43, "Halberd", "Long reach, halt a target's progress.", "W", 3, "D10"));
            output.Add(new EquipmentDataObj(44, "Scimitar", "On max dmg, attack another target.", "W", 5, "D8"));
            output.Add(new EquipmentDataObj(45, "Barbed Whip", "Induces bleed on target.", "W", 5, "D8"));
            output.Add(new EquipmentDataObj(46, "Short Bow", "Conceal, Use point blank.", "W", 1, "D6"));
            output.Add(new EquipmentDataObj(47, "Long Bow", "On max dmg, fire again.", "W", 3, "D8"));
            output.Add(new EquipmentDataObj(48, "Crossbow", "Takes 1 round to reload.", "W", 5, "D10"));
            output.Add(new EquipmentDataObj(49, "Musket", "Heard for miles, D6 phases to reload.", "W", 7, "D12"));
            output.Add(new EquipmentDataObj(50, "Flint Pistol", "Concealed, D6 phases to reload.", "W", 7, "D10"));
            output.Add(new EquipmentDataObj(51, "Cloak", "+3 Stealth skill", "A", 1, "1"));
            output.Add(new EquipmentDataObj(52, "Greaves", "Boots with armored shins.", "A", 1, "1"));
            output.Add(new EquipmentDataObj(53, "Leather Vest", "No protection against blunt force.", "A", 2, "2"));
            output.Add(new EquipmentDataObj(54, "Chain Mail", "Noisy", "A", 3, "3"));
            output.Add(new EquipmentDataObj(55, "Scale Vest", "Rare/requires expert blacksmith.", "A", 3, "3"));
            output.Add(new EquipmentDataObj(56, "Helm", "Draws enemy attention.", "A", 1, "1"));
            output.Add(new EquipmentDataObj(57, "Chest Plate", "-3 Stealth skill, cannot swim.", "A", 5, "4"));
            output.Add(new EquipmentDataObj(58, "Wood Shield", "Absorb 2 hits before attrition", "A", 3, "1"));
            output.Add(new EquipmentDataObj(59, "Steel Shield", "Absorb 3 hits before attrition", "A", 5, "2"));
            output.Add(new EquipmentDataObj(60, "Tower Shield", "Clumsy, ignore attrition from arrows", "A", 5, "3"));
            output.Add(new EquipmentDataObj(61, "Plumed Helmet", "+3 Defense, enrages enemies.", "CA", 3, "3"));
            output.Add(new EquipmentDataObj(62, "Silver Shield", "+6 Defense, repel lycanthrope attacks w no roll.", "CA", 3, "6"));
            output.Add(new EquipmentDataObj(63, "Sun Amulet", "This chain necklace holds 1 burst of sunlight.", "CE", 3));
            output.Add(new EquipmentDataObj(64, "Silver Darts", "12 thrown spikes of purest silver, D10 damage.", "CW", 3, "D10"));
            output.Add(new EquipmentDataObj(65, "Roc Feather", "Destroy to fly for 1D6 rounds.", "CE", 3));
            output.Add(new EquipmentDataObj(66, "Prophet's Hood", "Renew 1 spent spell daily.", "CE", 3));
            output.Add(new EquipmentDataObj(67, "Beads of Lurian", "If facing fear or panic, gain +5 Magic skill.", "CE", 3));
            output.Add(new EquipmentDataObj(68, "Great Bear Pelt", "Ignore penalties from cold or snow.", "CE", 3));
            output.Add(new EquipmentDataObj(69, "Giant Sword", "A 3D12 blade with +2 Defense.", "CWA", 3, "3D12|2"));
            output.Add(new EquipmentDataObj(70, "Song of Ullur", "Roll Magic to heal all allies 1 attrition.", "CE", 3));
            output.Add(new EquipmentDataObj(71, "Arconyx Ring", "Store 3D12 per rest, use on any future roll.", "CE", 3));
            output.Add(new EquipmentDataObj(72, "King's Plate", "Lesser undead cannot touch this plate armor.", "CA", 3, "4"));
            output.Add(new EquipmentDataObj(73, "Antler Dirk", "A D10 dagger that uses no metal parts.", "SW", 3, "D10"));
            output.Add(new EquipmentDataObj(74, "Karlan's Claws", "D10 fist weapons, victims bleed after hit.", "SW", 3, "D10"));
            output.Add(new EquipmentDataObj(75, "Spring Cable", "An elastic wire for base-jumping, holds 3 people.", "SE", 3));
            output.Add(new EquipmentDataObj(76, "Twistroot", "A fungal bud that drills through almost any lock.", "SE", 3));
            output.Add(new EquipmentDataObj(77, "Spellspark", "Once each dat, add 1 cast to 1 spell.", "SE", 3));
            output.Add(new EquipmentDataObj(78, "Kinetic Glove", "Add a damage die each consecutive attack, up to 3", "SE", 3));
            output.Add(new EquipmentDataObj(79, "Spellcannon", "A bulky pistol. Arm with 3 casts of a spell per rest", "SE", 3));
            output.Add(new EquipmentDataObj(80, "Night Hood", "In moonlight, you are all but invisible", "SE", 3));
            output.Add(new EquipmentDataObj(81, "Cold Iron Scythe", "2D12 blade, if you hit for 10+, kill your foe.", "SW", 3, "2D12"));
            output.Add(new EquipmentDataObj(82, "Thieves' Ruby", "A gem so pretty it causes a kind of hypnosis.", "SE", 3));
            output.Add(new EquipmentDataObj(83, "Fool's Coin", "When given, binds the recipient to a favor.", "SE", 3));
            output.Add(new EquipmentDataObj(84, "Black Crown", "If you see a foe healed, convert it to dmg.", "SE", 3));

            return output;
        }

        #endregion
    }
}
