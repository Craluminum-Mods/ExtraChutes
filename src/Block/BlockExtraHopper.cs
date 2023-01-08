using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace ExtraChutes
{
    class BlockExtraHopper : BlockHopper
    {
        public override string GetHeldItemName(ItemStack itemStack) => GetName();
        public override string GetPlacedBlockName(IWorldAccessor world, BlockPos pos) => GetName();

        private string GetName()
        {
            var material = Variant["material"];
            var part = Lang.Get($"material-{material}");
            return string.Format($"{Lang.Get("block-hopper")} ({part})");
        }
    }
}