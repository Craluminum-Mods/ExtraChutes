using System.Collections.Generic;

namespace ExtraChutes.Configuration
{
    class ChuteData
    {
        public Dictionary<string, bool> RecipeEnabled = new()
        {
            { "bismuthbronze", true },
            { "blackbronze", true },
            { "brass", true },
            { "gold", true },
            { "iron", true },
            { "lead", true },
            { "meteoriciron", true },
            { "molybdochalkos", true },
            { "silver", true },
            { "steel", true },
            { "tinbronze", true },
        };

        public Dictionary<string, float> FlowRate = new()
        {
            {"vanilla", 1},
            {"bismuthbronze", 1},
            {"blackbronze", 1},
            {"brass", 1},
            {"gold", 1},
            {"iron", 1},
            {"lead", 1},
            {"meteoriciron", 1},
            {"molybdochalkos", 1},
            {"silver", 1},
            {"steel", 1},
            {"tinbronze", 1},
        };

        public Dictionary<string, int> QuantitySlots = new()
        {
            {"vanilla", 1},
            {"bismuthbronze", 1},
            {"blackbronze", 1},
            {"brass", 1},
            {"gold", 1},
            {"iron", 1},
            {"lead", 1},
            {"meteoriciron", 1},
            {"molybdochalkos", 1},
            {"silver", 1},
            {"steel", 1},
            {"tinbronze", 1},
        };
    }
}