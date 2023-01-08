using System.Collections.Generic;

namespace ExtraChutes.Configuration
{
    class HorizontalHopperData
    {
        public Dictionary<string, bool> RecipeEnabled = new()
        {
            { "bismuthbronze", true },
            { "blackbronze", true },
            { "brass", true },
            { "copper", true },
            { "gold", true },
            { "iron", true },
            { "lead", true },
            { "meteoriciron", true },
            { "molybdochalkos", true },
            { "silver", true },
            { "steel", true },
            { "tinbronze", true },
        };

        public Dictionary<string, int> QuantitySlots = new()
        {
            {"bismuthbronze", 4},
            {"blackbronze", 4},
            {"brass", 4},
            {"copper", 4},
            {"gold", 4},
            {"iron", 4},
            {"lead", 4},
            {"meteoriciron", 4},
            {"molybdochalkos", 4},
            {"silver", 4},
            {"steel", 4},
            {"tinbronze", 4},
        };
    }
}