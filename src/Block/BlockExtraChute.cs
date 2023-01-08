using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace ExtraChutes
{
    class BlockExtraChute : BlockChute
    {
        public override string GetHeldItemName(ItemStack itemStack) => GetName();
        public override string GetPlacedBlockName(IWorldAccessor world, BlockPos pos) => GetName();

        private string GetName()
        {
            var original = Code.ToString();
            var material = Variant["material"];
            var part = Lang.Get($"material-{material}");

            original = original.Replace("extrachutes:", "game:block-");
            original = original.Replace($"{material}-", "");
            original = Lang.GetMatching(original);

            if (original.Contains("chute-cross-"))
            {
                return string.Format($"{Lang.Get("block-chute-cross-ground")} ({part})");
            }
            else
            {
                return string.Format($"{original} ({part})");
            }
        }
    }
}