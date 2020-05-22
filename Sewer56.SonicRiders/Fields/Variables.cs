﻿using System;
using System.Collections.Generic;
using System.Text;
using Sewer56.SonicRiders.Structures.Enums;
using Sewer56.SonicRiders.Structures.Gameplay;

namespace Sewer56.SonicRiders.Fields
{
    /// <summary>
    /// Contains various miscellaneous variables which do not have enough similar
    /// ones to group in the same category.
    /// </summary>
    public static unsafe class Variables
    {
        /// <summary>
        /// Does not affect level timer/state e.g. starting line, interactive elements.
        /// Setting this pauses the game without allowing the user to control the pause menu.
        /// </summary>
        public static readonly bool* IsPaused = (bool*)0x00696C28;

        /// <summary>
        /// Timer of the currently played race.
        /// </summary>
        public static readonly Timer* StageTimer = (Timer*) 0x692AE0;

        /// <summary>
        /// Declares the level/action stage to be loaded.
        /// </summary>
        public static readonly Levels* Level = (Levels*)0x692B90;

        /// <summary>
        /// Set to 1 to disable AI opponents entirely.
        /// The range for this is generally 1-8, else expect crashes.
        /// </summary>
        public static readonly byte* PlayerCount = (byte*)0x64B758;

        /// <summary>
        /// Manual toggle for the heads up display.
        /// Bear in mind that the game constantly overwrites this value - you
        /// need to nop the instructions that write to it.
        /// </summary>
        public static readonly bool* IsHUDVisible = (bool*)0x64B76C;

        /// <summary>
        /// Setting this to 1 zooms in the camera until you pass the start line.
        /// </summary>
        public static readonly bool* EnableStartLine2PCamera = (bool*)0x69126B;

        /// <summary>
        /// [Apply before racing]
        /// Setting this to 1, makes the HUD cover 1/4th of the screen for player 1.
        /// </summary>
        public static readonly bool* TwoPlayerHUDScale = (bool*)0x696C1C;

        /// <summary>
        /// Gets a pointer to the game state.
        /// </summary>
        /// <returns>Pointer to the gamestate, else nullptr.</returns>
        public static bool TryGetGameState(out GameState* state)
        {
            var baseAddress = *(byte**)0x016BF1D0;
            if (baseAddress != (byte*)0x0)
            {
                state = (GameState*)(baseAddress + 0x94);
                return true;
            }

            state = (GameState*) 0x0;
            return false;
        }
    }
}
