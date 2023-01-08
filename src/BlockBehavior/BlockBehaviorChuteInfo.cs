using System.Text;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.MathTools;

namespace ExtraChutes
{
    class BlockBehaviorChuteInfo : BlockBehavior
    {
        public BlockBehaviorChuteInfo(Block block) : base(block) { }

        public override string GetHeldBlockInfo(IWorldAccessor world, ItemSlot inSlot) => GetDescription(base.GetHeldBlockInfo(world, inSlot));
        public override string GetPlacedBlockInfo(IWorldAccessor world, BlockPos pos, IPlayer forPlayer) => GetDescription(base.GetPlacedBlockInfo(world, pos, forPlayer));

        private string GetDescription(string original)
        {
            var quantitySlots = Lang.Get("Quantity Slots: {0}", block.Attributes["quantitySlots"].AsFloat());
            var flowRate = string.Format("Flowrate: {0}", block.Attributes["item-flowrate"].AsFloat());

            quantitySlots = Lang.Get("extrachutes:format-bold-pastelbrown", quantitySlots);
            flowRate = Lang.Get("extrachutes:format-bold-pastelyellow", flowRate);

            var dsc = new StringBuilder();
            dsc.AppendFormat(quantitySlots);
            dsc.AppendLine();
            dsc.AppendFormat(flowRate);
            dsc.AppendLine();
            return original + dsc.ToString();
        }
    }
}