using MelonLoader;
using Ships.Interface.Values;

namespace BalancedMaterials
{
    public static class BuildInfo
    {
        public const string Name = "Balanced Materials";
        public const string Description = "Makes materials' hardness more fair";
        public const string Author = "jollyname";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class BalancedMaterials : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HullConstants.MetalHardness = 7.5f;
            HullConstants.GlassHardness = 2.5f;
            HullConstants.WoodHardness = 4.5f;
        }
    }
}