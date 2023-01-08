using Vintagestory.API.Common;

namespace ExtraChutes.Configuration
{
    static class ModConfig
    {
        private const string jsonConfig = "ExtraChutes.json";
        private static ExtraChutesConfig config;

        public static void ReadConfig(ICoreAPI api)
        {
            try
            {
                config = LoadConfig(api);

                if (config == null)
                {
                    GenerateConfig(api);
                    config = LoadConfig(api);
                }
                else
                {
                    GenerateConfig(api, config);
                }
            }
            catch
            {
                GenerateConfig(api);
                config = LoadConfig(api);
            }

            api.World.Config.SetFloat("extrachutes-chute-vanilla-flowrate", config.Chutes.FlowRate["vanilla"]);
            api.World.Config.SetInt("extrachutes-chute-vanilla-quantityslots", config.Chutes.QuantitySlots["vanilla"]);
            api.World.Config.SetInt("extrachutes-hopper-vanilla-quantityslots", config.Hoppers.QuantitySlots["vanilla"]);

            #region Chutes
            api.World.Config.SetBool("extrachutes-chute-bismuthbronze-recipe-enabled", config.Chutes.RecipeEnabled["bismuthbronze"]);
            api.World.Config.SetBool("extrachutes-chute-blackbronze-recipe-enabled", config.Chutes.RecipeEnabled["blackbronze"]);
            api.World.Config.SetBool("extrachutes-chute-brass-recipe-enabled", config.Chutes.RecipeEnabled["brass"]);
            api.World.Config.SetBool("extrachutes-chute-iron-recipe-enabled", config.Chutes.RecipeEnabled["iron"]);
            api.World.Config.SetBool("extrachutes-chute-steel-recipe-enabled", config.Chutes.RecipeEnabled["steel"]);
            api.World.Config.SetBool("extrachutes-chute-tinbronze-recipe-enabled", config.Chutes.RecipeEnabled["tinbronze"]);
            api.World.Config.SetBool("extrachutes-chute-molybdochalkos-recipe-enabled", config.Chutes.RecipeEnabled["molybdochalkos"]);
            api.World.Config.SetBool("extrachutes-chute-meteoriciron-recipe-enabled", config.Chutes.RecipeEnabled["meteoriciron"]);
            api.World.Config.SetBool("extrachutes-chute-lead-recipe-enabled", config.Chutes.RecipeEnabled["lead"]);
            api.World.Config.SetBool("extrachutes-chute-gold-recipe-enabled", config.Chutes.RecipeEnabled["gold"]);
            api.World.Config.SetBool("extrachutes-chute-silver-recipe-enabled", config.Chutes.RecipeEnabled["silver"]);

            api.World.Config.SetFloat("extrachutes-chute-bismuthbronze-flowrate", config.Chutes.FlowRate["bismuthbronze"]);
            api.World.Config.SetFloat("extrachutes-chute-blackbronze-flowrate", config.Chutes.FlowRate["blackbronze"]);
            api.World.Config.SetFloat("extrachutes-chute-brass-flowrate", config.Chutes.FlowRate["brass"]);
            api.World.Config.SetFloat("extrachutes-chute-iron-flowrate", config.Chutes.FlowRate["iron"]);
            api.World.Config.SetFloat("extrachutes-chute-steel-flowrate", config.Chutes.FlowRate["steel"]);
            api.World.Config.SetFloat("extrachutes-chute-tinbronze-flowrate", config.Chutes.FlowRate["tinbronze"]);
            api.World.Config.SetFloat("extrachutes-chute-molybdochalkos-flowrate", config.Chutes.FlowRate["molybdochalkos"]);
            api.World.Config.SetFloat("extrachutes-chute-meteoriciron-flowrate", config.Chutes.FlowRate["meteoriciron"]);
            api.World.Config.SetFloat("extrachutes-chute-lead-flowrate", config.Chutes.FlowRate["lead"]);
            api.World.Config.SetFloat("extrachutes-chute-gold-flowrate", config.Chutes.FlowRate["gold"]);
            api.World.Config.SetFloat("extrachutes-chute-silver-flowrate", config.Chutes.FlowRate["silver"]);

            api.World.Config.SetInt("extrachutes-chute-bismuthbronze-quantityslots", config.Chutes.QuantitySlots["bismuthbronze"]);
            api.World.Config.SetInt("extrachutes-chute-blackbronze-quantityslots", config.Chutes.QuantitySlots["blackbronze"]);
            api.World.Config.SetInt("extrachutes-chute-brass-quantityslots", config.Chutes.QuantitySlots["brass"]);
            api.World.Config.SetInt("extrachutes-chute-iron-quantityslots", config.Chutes.QuantitySlots["iron"]);
            api.World.Config.SetInt("extrachutes-chute-steel-quantityslots", config.Chutes.QuantitySlots["steel"]);
            api.World.Config.SetInt("extrachutes-chute-tinbronze-quantityslots", config.Chutes.QuantitySlots["tinbronze"]);
            api.World.Config.SetInt("extrachutes-chute-molybdochalkos-quantityslots", config.Chutes.QuantitySlots["molybdochalkos"]);
            api.World.Config.SetInt("extrachutes-chute-meteoriciron-quantityslots", config.Chutes.QuantitySlots["meteoriciron"]);
            api.World.Config.SetInt("extrachutes-chute-lead-quantityslots", config.Chutes.QuantitySlots["lead"]);
            api.World.Config.SetInt("extrachutes-chute-gold-quantityslots", config.Chutes.QuantitySlots["gold"]);
            api.World.Config.SetInt("extrachutes-chute-silver-quantityslots", config.Chutes.QuantitySlots["silver"]);
            #endregion

            #region Hoppers
            api.World.Config.SetBool("extrachutes-hopper-bismuthbronze-recipe-enabled", config.Hoppers.RecipeEnabled["bismuthbronze"]);
            api.World.Config.SetBool("extrachutes-hopper-blackbronze-recipe-enabled", config.Hoppers.RecipeEnabled["blackbronze"]);
            api.World.Config.SetBool("extrachutes-hopper-brass-recipe-enabled", config.Hoppers.RecipeEnabled["brass"]);
            api.World.Config.SetBool("extrachutes-hopper-iron-recipe-enabled", config.Hoppers.RecipeEnabled["iron"]);
            api.World.Config.SetBool("extrachutes-hopper-steel-recipe-enabled", config.Hoppers.RecipeEnabled["steel"]);
            api.World.Config.SetBool("extrachutes-hopper-tinbronze-recipe-enabled", config.Hoppers.RecipeEnabled["tinbronze"]);
            api.World.Config.SetBool("extrachutes-hopper-molybdochalkos-recipe-enabled", config.Hoppers.RecipeEnabled["molybdochalkos"]);
            api.World.Config.SetBool("extrachutes-hopper-meteoriciron-recipe-enabled", config.Hoppers.RecipeEnabled["meteoriciron"]);
            api.World.Config.SetBool("extrachutes-hopper-lead-recipe-enabled", config.Hoppers.RecipeEnabled["lead"]);
            api.World.Config.SetBool("extrachutes-hopper-gold-recipe-enabled", config.Hoppers.RecipeEnabled["gold"]);
            api.World.Config.SetBool("extrachutes-hopper-silver-recipe-enabled", config.Hoppers.RecipeEnabled["silver"]);

            api.World.Config.SetInt("extrachutes-hopper-bismuthbronze-quantityslots", config.Hoppers.QuantitySlots["bismuthbronze"]);
            api.World.Config.SetInt("extrachutes-hopper-blackbronze-quantityslots", config.Hoppers.QuantitySlots["blackbronze"]);
            api.World.Config.SetInt("extrachutes-hopper-brass-quantityslots", config.Hoppers.QuantitySlots["brass"]);
            api.World.Config.SetInt("extrachutes-hopper-iron-quantityslots", config.Hoppers.QuantitySlots["iron"]);
            api.World.Config.SetInt("extrachutes-hopper-steel-quantityslots", config.Hoppers.QuantitySlots["steel"]);
            api.World.Config.SetInt("extrachutes-hopper-tinbronze-quantityslots", config.Hoppers.QuantitySlots["tinbronze"]);
            api.World.Config.SetInt("extrachutes-hopper-molybdochalkos-quantityslots", config.Hoppers.QuantitySlots["molybdochalkos"]);
            api.World.Config.SetInt("extrachutes-hopper-meteoriciron-quantityslots", config.Hoppers.QuantitySlots["meteoriciron"]);
            api.World.Config.SetInt("extrachutes-hopper-lead-quantityslots", config.Hoppers.QuantitySlots["lead"]);
            api.World.Config.SetInt("extrachutes-hopper-gold-quantityslots", config.Hoppers.QuantitySlots["gold"]);
            api.World.Config.SetInt("extrachutes-hopper-silver-quantityslots", config.Hoppers.QuantitySlots["silver"]);
            #endregion

            #region Horizontal hoppers
            api.World.Config.SetBool("extrachutes-horhopper-copper-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["copper"]);
            api.World.Config.SetBool("extrachutes-horhopper-bismuthbronze-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["bismuthbronze"]);
            api.World.Config.SetBool("extrachutes-horhopper-blackbronze-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["blackbronze"]);
            api.World.Config.SetBool("extrachutes-horhopper-brass-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["brass"]);
            api.World.Config.SetBool("extrachutes-horhopper-iron-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["iron"]);
            api.World.Config.SetBool("extrachutes-horhopper-steel-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["steel"]);
            api.World.Config.SetBool("extrachutes-horhopper-tinbronze-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["tinbronze"]);
            api.World.Config.SetBool("extrachutes-horhopper-molybdochalkos-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["molybdochalkos"]);
            api.World.Config.SetBool("extrachutes-horhopper-meteoriciron-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["meteoriciron"]);
            api.World.Config.SetBool("extrachutes-horhopper-lead-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["lead"]);
            api.World.Config.SetBool("extrachutes-horhopper-gold-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["gold"]);
            api.World.Config.SetBool("extrachutes-horhopper-silver-recipe-enabled", config.HorizontalHoppers.RecipeEnabled["silver"]);

            api.World.Config.SetInt("extrachutes-horhopper-copper-quantityslots", config.HorizontalHoppers.QuantitySlots["copper"]);
            api.World.Config.SetInt("extrachutes-horhopper-bismuthbronze-quantityslots", config.HorizontalHoppers.QuantitySlots["bismuthbronze"]);
            api.World.Config.SetInt("extrachutes-horhopper-blackbronze-quantityslots", config.HorizontalHoppers.QuantitySlots["blackbronze"]);
            api.World.Config.SetInt("extrachutes-horhopper-brass-quantityslots", config.HorizontalHoppers.QuantitySlots["brass"]);
            api.World.Config.SetInt("extrachutes-horhopper-iron-quantityslots", config.HorizontalHoppers.QuantitySlots["iron"]);
            api.World.Config.SetInt("extrachutes-horhopper-steel-quantityslots", config.HorizontalHoppers.QuantitySlots["steel"]);
            api.World.Config.SetInt("extrachutes-horhopper-tinbronze-quantityslots", config.HorizontalHoppers.QuantitySlots["tinbronze"]);
            api.World.Config.SetInt("extrachutes-horhopper-molybdochalkos-quantityslots", config.HorizontalHoppers.QuantitySlots["molybdochalkos"]);
            api.World.Config.SetInt("extrachutes-horhopper-meteoriciron-quantityslots", config.HorizontalHoppers.QuantitySlots["meteoriciron"]);
            api.World.Config.SetInt("extrachutes-horhopper-lead-quantityslots", config.HorizontalHoppers.QuantitySlots["lead"]);
            api.World.Config.SetInt("extrachutes-horhopper-gold-quantityslots", config.HorizontalHoppers.QuantitySlots["gold"]);
            api.World.Config.SetInt("extrachutes-horhopper-silver-quantityslots", config.HorizontalHoppers.QuantitySlots["silver"]);
            #endregion
        }

        private static ExtraChutesConfig LoadConfig(ICoreAPI api) =>
            api.LoadModConfig<ExtraChutesConfig>(jsonConfig);

        private static void GenerateConfig(ICoreAPI api) =>
            api.StoreModConfig(new ExtraChutesConfig(), jsonConfig);

        private static void GenerateConfig(ICoreAPI api, ExtraChutesConfig previousConfig) =>
            api.StoreModConfig(new ExtraChutesConfig(previousConfig), jsonConfig);
    }
}