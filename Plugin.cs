using IPA;
using UnityEngine.SceneManagement;
using BeatSaberMarkupLanguage.MenuButtons;
using IPALogger = IPA.Logging.Logger;

namespace BS_RefreshButtons
{
    public class Plugin : IBeatSaberPlugin
    {
        internal static string Name => "BS-RefreshButtons";

        public void Init(IPALogger logger)
        {
            Logger.log = logger;
            Logger.log.Debug("Logger initialised.");
        }

        #region BSIPA Config
        // Uncomment to use BSIPA's config
        //internal static Ref<PluginConfig> config;
        //internal static IConfigProvider configProvider;
        //public void Init(IPALogger logger, [Config.Prefer("json")] IConfigProvider cfgProvider)
        //{
        //    Logger.log = logger;
        //    Logger.log.Debug("Logger initialised.");

        //    configProvider = cfgProvider;

        //    config = configProvider.MakeLink<PluginConfig>((p, v) =>
        //    {
        //        // Build new config file if it doesn't exist or RegenerateConfig is true
        //        if (v.Value == null || v.Value.RegenerateConfig)
        //        {
        //            Logger.log.Debug("Regenerating PluginConfig");
        //            p.Store(v.Value = new PluginConfig()
        //            {
        //                // Set your default settings here.
        //                RegenerateConfig = false
        //            });
        //        }
        //        config = v;
        //    });
        //}
        #endregion
        public void OnApplicationStart()
        {
            Logger.log.Debug("Creating Refresh Buttons");
            MenuButtons.instance.RegisterButton(new MenuButton("Refresh Songs", "Refresh your custom song library", delegate { SongCore.Loader.Instance.RefreshSongs(); }));
            MenuButtons.instance.RegisterButton(new MenuButton("Refresh Level Packs", "Refresh level packs", delegate { SongCore.Loader.Instance.RefreshLevelPacks(); }));
        }

        public void OnApplicationQuit()
        {
            Logger.log.Debug("OnApplicationQuit");

        }

        /// <summary>
        /// Runs at a fixed intervalue, generally used for physics calculations. 
        /// </summary>
        public void OnFixedUpdate()
        {

        }

        /// <summary>
        /// This is called every frame.
        /// </summary>
        public void OnUpdate()
        {

        }

        /// <summary>
        /// Called when the active scene is changed.
        /// </summary>
        /// <param name="prevScene">The scene you are transitioning from.</param>
        /// <param name="nextScene">The scene you are transitioning to.</param>
        public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
        {

        }

        /// <summary>
        /// Called when the a scene's assets are loaded.
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="sceneMode"></param>
        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {
            


        }

        public void OnSceneUnloaded(Scene scene)
        {

        }
    }
}
