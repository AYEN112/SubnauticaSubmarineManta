﻿using UnityEngine;
using Harmony;

namespace Manta.Patchers
{
    /**
     * Patches into Player::Update() so we can track if our debug key has been pressed.
     */
    [HarmonyPatch(typeof(Player))]
    [HarmonyPatch("Update")]
    public class OpenCloseDebugMenuPatcher
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Utilities.DebugMenu.main.Toggle();
            }
        }
    }
}
