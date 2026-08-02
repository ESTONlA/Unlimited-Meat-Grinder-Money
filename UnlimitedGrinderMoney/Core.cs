using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using System.Reflection;
using UnityEngine;

[assembly: MelonInfo(typeof(UnlimitedGrinderMoney.UnlimitedGrinderMoneyMod), "Unlimited meat Grinder Money", "1.0.0", "Estonia")]
[assembly: MelonGame(null, null)]

namespace UnlimitedGrinderMoney
{
    public class UnlimitedGrinderMoneyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Unlimited Grinder Money loaded.");
        }

        public override void OnUpdate()
        {
            var grinders = UnityEngine.Object.FindObjectsOfType<MeatGrinder>();

            foreach (var grinder in grinders)
            {
                if (grinder == null) continue;

                // Make the money reward absurdly high
                grinder.minMoneyReward = 999999;
                grinder.maxMoneyReward = 9999999;

                // Optional: make the grinder process much faster
                grinder.Delay = 0.1f;
            }
        }
    }
}