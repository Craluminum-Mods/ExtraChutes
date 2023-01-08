using Vintagestory.API.Common;
using Vintagestory.API.Config;

namespace ExtraChutes
{
    class ItemExtraChuteSection : Item
    {
        public override string GetHeldItemName(ItemStack itemStack) => GetName();

        private string GetName()
        {
            var material = Variant["material"];
            var part = Lang.Get("material-" + material);
            return string.Format($"{Lang.GetMatching("item-chutesection-*")} ({part})");
        }
    }
}