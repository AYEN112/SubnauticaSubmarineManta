﻿using UnityEngine;

namespace Submarines.DefaultCyclopsContent
{
    /**
     * Handles loading the default cyclops assets.
     * Call CyclopsDefaultAssets::LoadDefaultCyclopsContent once in game.
     * If called early it will only find a few assets rather than everything.
     */
    public class CyclopsDefaultAssets
    {
        private static bool initialised = false;
        public static FMODAsset DOCKING_DOORS_OPEN { get; private set; }
        public static FMODAsset DOCKING_DOORS_CLOSE { get; private set; }
        public static FMODAsset PLAYER_HATCH_OPEN { get; private set; }
        public static FMODAsset PLAYER_HATCH_CLOSE { get; private set; }
        public static FMODAsset COLLISION_IMPACT_SOLID_SOFT { get; private set; }
        public static FMODAsset COLLISION_IMPACT_SOLID_MEDIUM { get; private set; }
        public static FMODAsset COLLISION_IMPACT_SOLID_HARD { get; private set; }
        public static FMODAsset ENGINE_STATE_SILENT_RUNNING { get; private set; }
        public static FMODAsset ENGINE_STATE_AHEAD_STANDARD { get; private set; }
        public static FMODAsset ENGINE_STATE_AHEAD_SLOW { get; private set; }
        public static FMODAsset ENGINE_STATE_AHEAD_FAST { get; private set; }
        public static FMODAsset ENGINE_STATE_POWER_UP { get; private set; }
        public static FMODAsset ENGINE_STATE_POWER_DOWN { get; private set; }
        public static FMODAsset ENGINE_LOOP { get; private set; }
        public static FMODAsset AI_WELCOME_ABOARD_GOOD { get; private set; }

        public static void LoadDefaultCyclopsContent()
        {
            if (EntryPoint.LOAD_DEFAULT_CYCLOPS_ASSETS == false || initialised == true)
            {
                return;
            }

            LoadFMODAssets();
            initialised = true;
        }

        private static void LoadFMODAssets()
        {
            FMODAsset[] fmods = Resources.FindObjectsOfTypeAll<FMODAsset>();
            Utilities.Log.Print("Found: " + fmods.Length);
            foreach (FMODAsset fmod in fmods)
            {
                switch (fmod.name.ToLower())
                {
                    case "docking_doors_close":
                        DOCKING_DOORS_CLOSE = fmod;
                        DOCKING_DOORS_CLOSE = fmod;
                        break;
                    case "docking_doors_open":
                        DOCKING_DOORS_OPEN = fmod;
                        break;
                    case "outer_hatch_close":
                        PLAYER_HATCH_CLOSE = fmod;
                        break;
                    case "outer_hatch_open":
                        PLAYER_HATCH_OPEN= fmod;
                        break;
                    case "impact_solid_medium":
                        COLLISION_IMPACT_SOLID_MEDIUM = fmod;
                        break;
                    case "impact_solid_soft":
                        COLLISION_IMPACT_SOLID_SOFT = fmod;
                        break;
                    case "impact_solid_hard":
                        COLLISION_IMPACT_SOLID_HARD = fmod;
                        break;
                    case "ai_silent_running":
                        ENGINE_STATE_SILENT_RUNNING = fmod;
                        break;
                    case "ai_ahead_standard":
                        ENGINE_STATE_AHEAD_STANDARD = fmod;
                        break;
                    case "ai_ahead_slow":
                        ENGINE_STATE_AHEAD_SLOW = fmod;
                        break;
                    case "ai_ahead_flank":
                        ENGINE_STATE_AHEAD_FAST = fmod;
                        break;
                    case "ai_engine_up":
                        ENGINE_STATE_POWER_UP = fmod;
                        break;
                    case "ai_engine_down":
                        ENGINE_STATE_POWER_DOWN = fmod;
                        break;
                    case "ai_welcome":
                        AI_WELCOME_ABOARD_GOOD = fmod;
                        break;
                    case "cyclops_loop_rpm":
                        ENGINE_LOOP = fmod;
                        break;
                }
            }
        }
    }
}
