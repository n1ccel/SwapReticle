using ABI_RC.Core.Player;
using MelonLoader;
using System;
using System.Reflection;

namespace Misatyan
{
    public class Misa : MelonMod
    {
        public static Misa Instance { get; private set; }
        public MelonLogger.Instance Logger => Instance.LoggerInstance;

        //Swap shit CVR's riticle to good red point
        [Obsolete]
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(ReticleSwitch.WaitForMenu());
            //MelonCoroutines.Start(MainGUI.WaitForMenu());
            Instance = this;
        }
    }
}

