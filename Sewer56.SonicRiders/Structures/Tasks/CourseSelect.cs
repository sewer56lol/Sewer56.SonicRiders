﻿using System.Runtime.InteropServices;
using Sewer56.SonicRiders.Structures.Enums;
using Sewer56.SonicRiders.Structures.Tasks.Enums.Shared;

namespace Sewer56.SonicRiders.Structures.Tasks
{
    /// <summary>
    /// Note: Size is a decent estimate, real size is not known.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct CourseSelect
    {
        [FieldOffset(0x04)]
        public byte HighlightedHorizontalItem;

        /// <summary>
        /// If to 1 and task state 0, enters next menu.
        /// If to 0 and task state 0, leaves current menu.
        /// </summary>
        [FieldOffset(0x08)]
        public int NextMenu;

        [FieldOffset(0x0C)]
        public MenuState MenuState;

        [FieldOffset(0x0D)]
        public byte SelectionHorizontal;

        [FieldOffset(0x0E)]
        public byte SelectionVertical;

        [FieldOffset(0x0F)]
        public MenuState SubmenuState;

        /// <summary>
        /// Individual Track Order by Index. i.e. 1 2 3 4 5 6 7 8
        /// </summary>
        [FieldOffset(0x10)]
        public fixed byte StageOrder[8];

        /// <summary>
        /// Stage Select List Scroll Value.
        /// e.g. Setting 1 makes Splash Canyon on left.
        /// </summary>
        [FieldOffset(0x18)]
        public byte ListScrollOffset;

        /// <summary>
        /// Vertical submenu selection.
        /// e.g. Setting 1 selects Night Chase in Metal City's submenu.
        /// </summary>
        [FieldOffset(0x1A)]
        public byte SubmenuSelection;

        /// <summary>
        /// Vertical submenu selection.
        /// </summary>
        [FieldOffset(0x1B)]
        public RaceMode RaceMode;
    }
}
