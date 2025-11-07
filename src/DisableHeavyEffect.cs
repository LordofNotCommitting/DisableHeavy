//using HarmonyLib;
//using MGSC;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEngine;

using HarmonyLib;
using MGSC;

namespace DisableHeavy
{
    /// <summary>
    /// A Unity Debug Logger that includes the assembly name.
    /// Makes finding the mod that created the log entry easy to find.
    /// Calls the Unity.Debug functions that match the function names.
    /// </summary>
    /// 
    [HarmonyPatch(typeof(Player), nameof(Player.OnMoved))]
    public class DisableHeavyEffect
    {
        static void Postfix(ref Player __instance)
        {
            __instance.CreatureData.EffectsController.RemoveAllEffects<HeavyWeaponEffect>();
            return;
        }
        
    }
}