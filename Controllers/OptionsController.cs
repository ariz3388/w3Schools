using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using w3schools.Managers;
using w3schools.Models;

namespace w3schools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private OptionsManager optionsManager = new OptionsManager();

        [HttpGet("{action}/{selectedId}")]
        public string GetSkills(int selectedId = -1)
        {           
            return optionsManager.Get("SKILLS", selectedId, false);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetLineage(int selectedId = -1)
        {
            return optionsManager.Get("LINEAGE", selectedId, true);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetEquipmentForGenerator(int selectedId = -1)
        {
            return optionsManager.Get("GEQUIPMENT", selectedId, true);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetBasicEquipmentOptions(int selectedId = -1)
        {
            return optionsManager.Get("EQUIPMENT", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetBasicWeaponOptions(int selectedId = -1)
        {
            return optionsManager.Get("WEAPON", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetBasicArmorOptions(int selectedId = -1)
        {
            return optionsManager.Get("ARMOR", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetLargeEquipmentOptions(int selectedId = -1)
        {
            return optionsManager.Get("LARGE", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetCrownEquipmentOptions(int selectedId = -1)
        {
            return optionsManager.Get("CEQUIPMENT", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetCrownWeaponOptions(int selectedId = -1)
        {
            return optionsManager.Get("CWEAPON", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetCrownArmorOptions(int selectedId = -1)
        {
            return optionsManager.Get("CARMOR", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetSkullEquipmentOptions(int selectedId = -1)
        {
            return optionsManager.Get("SEQUIPMENT", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetSkullWeaponOptions(int selectedId = -1)
        {
            return optionsManager.Get("SWEAPON", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetSkullArmorOptions(int selectedId = -1)
        {
            return optionsManager.Get("SARMOR", selectedId);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetPastOptions(int selectedId = -1)
        {
            return optionsManager.Get("PAST", selectedId, true);
        }

        [HttpGet("{action}/{selectedId}")]
        public string GetPurposeOptions(int selectedId = -1)
        {
            return optionsManager.Get("PURPOSE", selectedId, true);
        }
    }
}
