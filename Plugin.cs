using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace MyName.MyModName
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ModBase : BaseUnityPlugin
    {
        private const string modGUID = "MyName.MyModName";
        private const string modName = "Template mod";
        private const string modVersion = "0.1.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        public static ModBase Instance;

        public ManualLogSource mlogger;

        void Awake()
        {
            if(Instance == null) Instance = this;

            mlogger = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mlogger.LogInfo($"Loading {modName}");
            harmony.PatchAll();
        }
    }
}
