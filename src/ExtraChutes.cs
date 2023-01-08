using ExtraChutes.Configuration;
using Vintagestory.API.Common;
using Vintagestory.API.Util;
using Vintagestory.GameContent;

[assembly: ModInfo("Extra Chutes",
    Authors = new[] { "Craluminum2413" })]

namespace ExtraChutes
{
    class ExtraChutes : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            ModConfig.ReadConfig(api);
            api.RegisterItemClass("EC_ItemExtraChuteSection", typeof(ItemExtraChuteSection));
            api.RegisterBlockClass("EC_BlockExtraChute", typeof(BlockExtraChute));
            api.RegisterBlockClass("EC_BlockExtraHopper", typeof(BlockExtraHopper));
            api.RegisterBlockBehaviorClass("EC_ChuteInfo", typeof(BlockBehaviorChuteInfo));
            api.World.Logger.Event("started 'Extra Chutes' mod");
        }

        public override void AssetsFinalize(ICoreAPI api)
        {
            foreach (var block in api.World.Blocks)
            {
                if (block is not BlockChute) continue;
                block.BlockBehaviors = block.BlockBehaviors.Append(new BlockBehaviorChuteInfo(block));
                block.CollectibleBehaviors = block.CollectibleBehaviors.Append(new BlockBehaviorChuteInfo(block));
            }
        }
    }
}