namespace ExtraChutes.Configuration
{
    class ExtraChutesConfig
    {
        public ChuteData Chutes = new();
        public HopperData Hoppers = new();
        public HorizontalHopperData HorizontalHoppers = new();

        public ExtraChutesConfig() { }

        public ExtraChutesConfig(ExtraChutesConfig previousConfig)
        {
            Chutes = previousConfig.Chutes;
            Hoppers = previousConfig.Hoppers;
            HorizontalHoppers = previousConfig.HorizontalHoppers;
        }
    }
}